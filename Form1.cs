using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZADATAKA3
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-10-10\Documents\Snezana\ZADATAKA3\A3.mdf;Integrated Security=True");
       

        public Form1()
        {
            InitializeComponent();
           

        }
        private void OsveziList()
        {
            SqlCommand cmd = new SqlCommand("select * from Projekat", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                listView1.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem li = new ListViewItem(row[0].ToString());
                    li.SubItems.Add(row[1].ToString());
                    li.SubItems.Add(((DateTime)row[2]).ToString("dd.MM.yyyy"));
                    li.SubItems.Add(row[3].ToString());
                    li.SubItems.Add(row[4].ToString());
                    li.SubItems.Add(row[5].ToString());
                    listView1.Items.Add(li);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Doslo je do greske");
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OsveziList();
        }
        private void Clear()
        {
            textBoxSifra.Text = "";
            textBoxOpis.Text = "";
            textBoxBudzet.Text = "";
            textBoxDatum.Text = "";
            textBoxNaziv.Text = "";
            checkBox1.Checked = false;
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                textBoxSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxDatum.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxBudzet.Text = listView1.SelectedItems[0].SubItems[3].Text;
                if (listView1.SelectedItems[0].SubItems[4].Text == "True")
                    checkBox1.Checked = true;
                else
                    checkBox1.Checked = false;
                textBoxOpis.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                Clear();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (textBoxSifra.Text != "")
            {
                DateTime datPoc = DateTime.ParseExact(textBoxDatum.Text, "dd.MM.yyyy", null);
                DateTime danDat = DateTime.Now;
             
                if ((danDat.Year - datPoc.Year) >= 5 && checkBox1.Checked == true)
                    try
                    {
            
                        SqlCommand command = new SqlCommand("DELETE FROM Projekat WHERE ProjekatID = @Id", conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(textBoxSifra.Text));
                        command.ExecuteNonQuery();
                        conn.Close();
                        OsveziList();
                        UpisiUtxt();
                        Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Došlo je do greške pri brisanju podataka");
                    }
                else
                {
                    MessageBox.Show("Ovaj projekat ne zadovoljava uslove za brisanje");
                }
            }
            else
            {
                MessageBox.Show("Izaberite projekat koji brišete");
            }
        }
        private void UpisiUtxt()
        {
            string fileName = String.Format("log_{0}_{1}_{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string path = @"..\..\" + fileName; // folder projekta PUTANJA
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(String.Format("{0} - {1}", textBoxSifra.Text, textBoxNaziv.Text));
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 foa = new Form2();
            foa.ShowDialog();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlUpit = "SELECT YEAR(p.DatumPocetka) AS Godina, COUNT(DISTINCT p.ProjekatID) AS 'Broj projekata', COUNT(DISTINCT a.RadnikID) AS 'Broj radnika'  FROM Projekat AS p, Angazman AS a WHERE p.ProjekatID = a.ProjekatID AND DATEDIFF(year,p.DatumPocetka,GETDATE())<@starost GROUP BY YEAR(p.DatumPocetka) ORDER BY YEAR(p.DatumPocetka)";
                conn.Open();
                SqlCommand komanda = new SqlCommand(sqlUpit, conn);
                komanda.Parameters.AddWithValue("@starost", numericUpDown1.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
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
