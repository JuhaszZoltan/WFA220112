using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220112
{
    public partial class FrmUtasa : Form
    {
        public FrmUtasa()
        {
            InitializeComponent();
            Icon = Properties.Resources.utas;
        }

        private void FrmUtasa_Load(object sender, EventArgs e)
        {
            string kd = Program.MaiDatum.ToString("yyyy-MM-01");
            string vd = Program.MaiDatum.AddMonths(2).ToString("yyyy-MM-01");

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var sqlReader = new SqlCommand(
                    "SELECT t_kod FROM tura " +
                    $"WHERE kezdet >= '{kd}' AND kezdet < '{vd}';",
                    conn).ExecuteReader();

                while (sqlReader.Read())
                {
                    cbJelentkezes.Items.Add(sqlReader[0]);
                }
            }
        }

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmUtasLista(this).ShowDialog();

        private void tbUtasKod_TextChanged(object sender, EventArgs e) 
            => tsmiTorles.Enabled = !string.IsNullOrEmpty(tbUtasKod.Text);

        private void UresUrlap()
        {
            tbUtasKod.Text = null;
            tbNev.Text = null;
            rtbCim.Text = null;
            cbJelentkezes.Text = null;
            cbJelentkezes.SelectedIndex = -1;

        }

        private void TsmiMentes_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;
            string jelentkezikString =
                (string.IsNullOrWhiteSpace(cbJelentkezes.Text) ? "null" : cbJelentkezes.Text);

            if (string.IsNullOrWhiteSpace(tbNev.Text))
                errorMessage += "A 'név' mező kitöltése kötelező!\n";
            if (string.IsNullOrWhiteSpace(rtbCim.Text))
                errorMessage += "A 'cím' mező kitöltése kötelező!\n";

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    caption: "HIBA",
                    text: errorMessage,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(tbUtasKod.Text))
                {
                    using (var conn = new SqlConnection(Program.ConnectionString))
                    {
                        conn.Open();

                        var sqlReader = new SqlCommand(
                            "SELECT MAX(u_kod) + 1 FROM utas;",
                            conn).ExecuteReader();
                        sqlReader.Read();
                        var nextUKod = sqlReader[0];
                        sqlReader.Close();

                        var sqlAdapter = new SqlDataAdapter()
                        {
                            InsertCommand = new SqlCommand(
                                $"INSERT INTO utas VALUES " +
                                $"({nextUKod}, '{tbNev.Text}', '{rtbCim.Text}', " +
                                $"{jelentkezikString});", conn),
                        };

                        try
                        {
                            sqlAdapter.InsertCommand.ExecuteNonQuery();
                            tbUtasKod.Text = $"{nextUKod}";
                            MessageBox.Show("Az új adat rögzítése megtörtént!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                }
                else
                {
                    using (var conn = new SqlConnection(Program.ConnectionString))
                    {
                        conn.Open();

                        var sqlAdapter = new SqlDataAdapter()
                        {
                            UpdateCommand = new SqlCommand(
                                "UPDATE utas SET " +
                                $"nev = '{tbNev.Text}', " +
                                $"cim = '{rtbCim.Text}', " +
                                $"jelentkezik = {jelentkezikString} " +
                                $"WHERE u_kod = {tbUtasKod.Text};", conn),
                        };

                        try
                        {
                            sqlAdapter.UpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Az adatok frissítése megtörtént!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void TsmiTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "FIGYELMEZTETÉS",
                text: "Biztosan törölni kívánod?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    var sqlAdapter = new SqlDataAdapter()
                    {
                        DeleteCommand = new SqlCommand(
                            "DELETE FROM utas " +
                            $"WHERE u_kod = {tbUtasKod.Text};", conn),
                    };

                    try
                    {
                        sqlAdapter.DeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("rekord sikeresen törölve!");
                        UresUrlap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void TsmiUresUrlap_Click(object sender, EventArgs e)
            => UresUrlap();
    }
}
