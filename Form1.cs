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

namespace A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osveziListu();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                textBoxSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxDatumPoc.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxBudzet.Text = listView1.SelectedItems[0].SubItems[3].Text;
                if (listView1.SelectedItems[0].SubItems[4].Text == "True")
                    checkBoxZavrsen.Checked = true;
                else
                    checkBoxZavrsen.Checked = false;
                textBoxOpis.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                textBoxSifra.Text = "";
                textBoxNaziv.Text = "";
                textBoxDatumPoc.Text = "";
                textBoxBudzet.Text = "";
                checkBoxZavrsen.Checked = false;
                textBoxOpis.Text = "";
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A3.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand
                ("DELETE FROM Projekat WHERE ProjekatID=@sif", conn);
            cmd.Parameters.AddWithValue("@sif",
                Convert.ToInt32(textBoxSifra.Text));
            // Provera parsovanjem, TryParse umesto Convert...
            if(!checkBoxZavrsen.Checked)
            {
                MessageBox.Show("Projekat nije zavrsen!");
                return;
            }
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //listView1.Items.Remove(listView1.SelectedItems[0]);
                osveziListu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }
        private void osveziListu()
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A3.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM Projekat", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                listView1.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(((DateTime)dr[2]).ToString("dd.MM.yyyy"));
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }
    }
}
