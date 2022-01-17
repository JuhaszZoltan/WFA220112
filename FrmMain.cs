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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Icon = Properties.Resources.logo;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblDatum.Text = Program.MaiDatum.ToString("yyyy. MMMM dd.");

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var sqlReader = new SqlCommand(
                    "SELECT t_kod, hova, kezdet, vege, idegenvezeto.nev, szallas.nev, ar " +
                    "FROM tura " +
                    "INNER JOIN idegenvezeto ON vezeto = i_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    "INNER JOIN szallas ON szallas = sz_kod " +
                    $"WHERE kezdet >= '{Program.MaiDatum.ToString("yyyy-MM-01")}';",
                    conn).ExecuteReader();
                while (sqlReader.Read())
                {
                    dgvMain.Rows.Add(
                        sqlReader[0],
                        sqlReader[1],
                        sqlReader.GetDateTime(2).ToString("yyyy. MM. dd."),
                        sqlReader.GetDateTime(3).ToString("yyyy. MM. dd."),
                        sqlReader[4],
                        sqlReader[5],
                        sqlReader[6]);
                }
            }
        }

        private void TsmiSzerkesztes_Click(object sender, EventArgs e)
            => new FrmUtasa().ShowDialog();

        private void tsmiKereses_Click(object sender, EventArgs e)
            => new FrmUtasLista(null).ShowDialog();
    }
}
