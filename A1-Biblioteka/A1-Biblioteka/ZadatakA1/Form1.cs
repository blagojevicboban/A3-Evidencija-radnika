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

namespace ZadatakA1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
                buttonUpisi.Enabled = false;
            OsveziListview();
            OsveziComboCitalaca();
            richTextBox1.LoadFile("dokum.rtf");
        }

        private void OsveziListview()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Citalac";
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
                    li.SubItems.Add(row[2].ToString());
                    li.SubItems.Add(row[3].ToString());
                    li.SubItems.Add(row[4].ToString());
                    listView1.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske! " + ex.Message);
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                clearData();
                return;
            }
            try
            {
                int.Parse(textBoxId.Text);
            }
            catch
            {
                MessageBox.Show("Unesite ispravnu šifru");
                textBoxId.Text = "";
                clearData();
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Citalac WHERE CitalacID = @id";
            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    textBoxJMBG.Text = dt.Rows[0][1].ToString();
                    textBoxIme.Text = dt.Rows[0][2].ToString();
                    textBoxPrezime.Text = dt.Rows[0][3].ToString();
                    textBoxAdresa.Text = dt.Rows[0][4].ToString();
                    buttonUpisi.Enabled=false;
                }
                else
                {
                    clearData();
                    buttonUpisi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void clearData()
        {
            textBoxIme.Text = "";
            textBoxJMBG.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            buttonUpisi.Enabled = true;
        }

        private void buttonUpisi_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxJMBG.Text != "" && textBoxIme.Text != "" && textBoxPrezime.Text != "" && textBoxAdresa.Text != "")
            {
                buttonUpisi.Enabled = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Citalac(CitalacID, MaticniBroj, Ime, Prezime, Adresa) VALUES (@id, @jmbg, @ime, @prezime, @adresa)";
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                cmd.Parameters.AddWithValue("@jmbg", textBoxJMBG.Text);
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@adresa", textBoxAdresa.Text);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesan unos");
                    OsveziListview();
                    OsveziComboCitalaca();
                    textBoxId.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Čitalac sa tim brojem članske karte postoji u evidenciji");
                    textBoxId.Focus();
                    return;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Morate da unesete broj članske karte");
            }
        }
        private void Oznaci()
        {
            listView1.Focus();
            var item=this.listView1.FindItemWithText(textBoxId.Text);
            listView1.FullRowSelect = true;
            listView1.Items[item.Index].Selected = true;
        }

        private void tbIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OsveziComboCitalaca()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CitalacID, CONCAT(CitalacID,'-',Ime,' ',Prezime) AS prikaz FROM Citalac";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                comboBoxCitalac.DataSource = dt;
                comboBoxCitalac.DisplayMember = "prikaz";
                comboBoxCitalac.ValueMember = "CitalacID";
                comboBoxCitalac.Text = "";
                comboBoxCitalac.SelectedValue = -1;

            }
            catch
            {
                MessageBox.Show("Doslo je do greske!");
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (comboBoxCitalac.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT CONCAT(c.Ime, ' ', c.Prezime) AS 'Citalac', 
                                DATEPART(year, nc.DatumUzimanja) AS 'Godina', 
                                COUNT(DatumUzimanja) AS 'Broj iznajmljenih',
                                (COUNT(DatumUzimanja) - COUNT(DatumVracanja)) AS 'Nije vraceno'
                                FROM Citalac AS c, Na_Citanju AS nc
                                WHERE c.CitalacID = nc.CitalacID 
                                AND c.CitalacID = @id 
                                AND DATEPART(year, nc.DatumUzimanja) BETWEEN @od AND @do
                                GROUP BY DATEPART(year, nc.DatumUzimanja), c.Ime, c.Prezime";
                cmd.Parameters.AddWithValue("@id", comboBoxCitalac.SelectedValue);
                cmd.Parameters.AddWithValue("@od", dateTimePickerOd.Value.Year);
                cmd.Parameters.AddWithValue("@do", dateTimePickerDo.Value.Year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    chart1.DataSource = dt;
                    chart1.Series[0].XValueMember = "Godina";
                    chart1.Series[0].YValueMembers = "Broj iznajmljenih";
                    chart1.Series[1].XValueMember = "Godina";
                    chart1.Series[1].YValueMembers = "Nije vraceno";
                    chart1.Series[0].IsValueShownAsLabel = false;
                    chart1.Series[1].IsValueShownAsLabel = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    da.Dispose();
                    cmd.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Izaberite nekog od čitalaca !");
                comboBoxCitalac.Focus();
                return;
            }
        }
    }
}
