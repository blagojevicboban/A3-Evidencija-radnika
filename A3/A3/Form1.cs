using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace A3
{
    public partial class Form1 : Form
    {
       SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A3.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void PrikaziPodLView()
        {
            listView1.Items.Clear();
            try
            {
                konekcija.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Projekat", konekcija);
                adapter.Fill(dataTable);
                konekcija.Close();
                listView1.FullRowSelect = true;
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem listItem = new ListViewItem(row["ProjekatID"].ToString());
                    listItem.SubItems.Add(row["Naziv"].ToString());
                    var datpoc = DateTime.Parse(row["DatumPocetka"].ToString());
                    listItem.SubItems.Add(datpoc.ToString("dd.MM.yyyy"));
                    listItem.SubItems.Add(row["Budzet"].ToString());
                    listItem.SubItems.Add(row["ProjekatZavrsen"].ToString());
                    listItem.SubItems.Add(row["Opis"].ToString());
                    listView1.Items.Add(listItem); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            tbSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
            tbNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbDatPoc.Text = listView1.SelectedItems[0].SubItems[2].Text;
            tbBudzet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            chbZavrsen.Checked  = Convert.ToBoolean(listView1.SelectedItems[0].SubItems[4].Text);
            tbOpis.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void ClearData()
        {
            tbSifra.Text = "";
            tbNaziv.Text = "";
            tbDatPoc.Text = "";
            tbBudzet.Text = "";
            chbZavrsen.Checked = false;
            tbOpis.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziPodLView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            {
                if (tbSifra.Text!="" )
                {
                    DateTime datPoc = DateTime.ParseExact(tbDatPoc.Text, "dd.MM.yyyy", null);
                    DateTime danDat = DateTime.Today;
                    int starost = (danDat.Year - datPoc.Year);
                    Boolean zavrsen = Convert.ToBoolean(chbZavrsen.Checked);

                    if (starost >= 5 && zavrsen == true)

                    try
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM Projekat WHERE ProjekatID = @Id", konekcija);
                        konekcija.Open();
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(tbSifra.Text));
                        command.ExecuteNonQuery();
                        konekcija.Close();

                        PrikaziPodLView();
                        UpisiUtxt();
                        ClearData();
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
        }

        private void UpisiUtxt()
        {
            string fileName = String.Format("log_{0}_{1}_{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string path = fileName;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(String.Format("{0} - {1}", tbSifra.Text, tbNaziv.Text));
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Statistika  frm = new Statistika ();
            frm.Show();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            UpisiUtxt();
        }
    }
}