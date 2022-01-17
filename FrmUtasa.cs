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
            //nev & cim notNull or empty exc

            if (string.IsNullOrEmpty(tbUtasKod.Text))
            {
                //TODO:::
                MessageBox.Show("INSERT");
                //fill btUtasKod
            }
            else
            {
                //TODO:::
                MessageBox.Show("UPDATE");
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
                //TODO:::
                MessageBox.Show("DELETE");
                UresUrlap();
            }
        }

        private void TsmiUresUrlap_Click(object sender, EventArgs e)
            => UresUrlap();
    }
}
