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
    public partial class FrmUtasLista : Form
    {
        public FrmUtasa FrmUtas { get; set; } = null;
        public FrmUtasLista(FrmUtasa frmUtas)
        {
            FrmUtas = frmUtas;
            InitializeComponent();
            Icon = Properties.Resources.utas;
        }

        private void FrmUtasLista_Load(object sender, EventArgs e)
            => Lekerdezes();
        private void TbNevSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();
        private void TbCelSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();

        private void Lekerdezes()
        {
            dgvUtasLista.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var sqlReader = new SqlCommand(
                    "SELECT u_kod, nev, cim, jelentkezik, kezdet, hova " +
                    "FROM utas " +
                    "INNER JOIN tura ON jelentkezik = t_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    $"WHERE nev LIKE '{tbNevSzures.Text}%' AND hova LIKE '{tbCelSzures.Text}%' " +
                    "ORDER BY nev, kezdet;",
                    conn).ExecuteReader();

                while (sqlReader.Read())
                {
                    dgvUtasLista.Rows.Add(
                        sqlReader[0],
                        sqlReader[1],
                        sqlReader[2],
                        sqlReader[3],
                        sqlReader.GetDateTime(4).ToString("yyyy.MM.dd."),
                        sqlReader[5]);
                }
            }
        }

        private void DgvUtasLista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FrmUtas != null)
            {
                FrmUtas.tbUtasKod.Text = dgvUtasLista[0, e.RowIndex].Value.ToString();
                FrmUtas.tbNev.Text = dgvUtasLista[1, e.RowIndex].Value.ToString();
                FrmUtas.rtbCim.Text = dgvUtasLista[2, e.RowIndex].Value.ToString();
                FrmUtas.cbJelentkezes.Text = dgvUtasLista[3, e.RowIndex].Value.ToString();

                this.Close();
            }
        }
    }
}
