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
        DateTime kamudatum = DateTime.Parse("2015-10-11");
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.logo;

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(
                    "SELECT t_kod, hova, kezdet, vege, idegenvezeto.nev, szallas.nev, ar " +
                    "FROM tura " +
                    "INNER JOIN idegenvezeto ON vezeto = i_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    "INNER JOIN szallas ON szallas = sz_kod " +
                    $"WHERE kezdet >= '{kamudatum.ToString("yyyy-MM-01")}';", conn);
                    // $"WHERE kezdet >= '{DateTime.Now.ToString("yyyy-MM") + "-01"}';", conn);

                var sqlReader = sqlCommand.ExecuteReader();

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
    }
}
