using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace A3
{
    public partial class Statistika : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A3.mdf;Integrated Security=True");

        public Statistika()
        {
            InitializeComponent();
        }


        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlUpit = "SELECT YEAR(p.DatumPocetka) AS Godina, COUNT(DISTINCT p.ProjekatID) AS 'Broj projekata', COUNT(DISTINCT a.RadnikID) AS 'Broj radnika'  FROM Projekat AS p, Angazman AS a WHERE p.ProjekatID = a.ProjekatID AND DATEDIFF(year,p.DatumPocetka,GETDATE())<@starost GROUP BY YEAR(p.DatumPocetka) ORDER BY YEAR(p.DatumPocetka)";
                konekcija.Open();
                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                komanda.Parameters.AddWithValue("@starost", numUD.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                konekcija.Close();
                dataGridView1.DataSource = dt;
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Godina";
                chart1.Series[0].YValueMembers = "Broj radnika";
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do greške");
            }

        }
    }
}
