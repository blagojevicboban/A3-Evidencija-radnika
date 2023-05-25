namespace ZadatakA1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonJMBG = new System.Windows.Forms.Button();
            this.buttonUpisi = new System.Windows.Forms.Button();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCitalac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.buttonJMBG);
            this.tabPage1.Controls.Add(this.buttonUpisi);
            this.tabPage1.Controls.Add(this.textBoxAdresa);
            this.tabPage1.Controls.Add(this.textBoxPrezime);
            this.tabPage1.Controls.Add(this.textBoxIme);
            this.tabPage1.Controls.Add(this.textBoxJMBG);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1185, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Čitaoci";
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(400, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 379);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Članska karta";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JMBG";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.Width = 122;
            // 
            // buttonJMBG
            // 
            this.buttonJMBG.BackColor = System.Drawing.Color.White;
            this.buttonJMBG.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonJMBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonJMBG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonJMBG.Location = new System.Drawing.Point(57, 358);
            this.buttonJMBG.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJMBG.Name = "buttonJMBG";
            this.buttonJMBG.Size = new System.Drawing.Size(308, 50);
            this.buttonJMBG.TabIndex = 2;
            this.buttonJMBG.Text = "Izađi";
            this.buttonJMBG.UseVisualStyleBackColor = false;
            this.buttonJMBG.Click += new System.EventHandler(this.tbIzadji_Click);
            // 
            // buttonUpisi
            // 
            this.buttonUpisi.BackColor = System.Drawing.Color.White;
            this.buttonUpisi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonUpisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpisi.ForeColor = System.Drawing.Color.Red;
            this.buttonUpisi.Location = new System.Drawing.Point(57, 287);
            this.buttonUpisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpisi.Name = "buttonUpisi";
            this.buttonUpisi.Size = new System.Drawing.Size(308, 50);
            this.buttonUpisi.TabIndex = 2;
            this.buttonUpisi.Text = "Upiši čitaoca";
            this.buttonUpisi.UseVisualStyleBackColor = false;
            this.buttonUpisi.Click += new System.EventHandler(this.buttonUpisi_Click);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(156, 224);
            this.textBoxAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(208, 22);
            this.textBoxAdresa.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(156, 178);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(208, 22);
            this.textBoxPrezime.TabIndex = 1;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(156, 138);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(208, 22);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(156, 98);
            this.textBoxJMBG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(208, 22);
            this.textBoxJMBG.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(220, 55);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(144, 22);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "JMBG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br članske karte";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonIzadji);
            this.tabPage2.Controls.Add(this.buttonPrikazi);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBoxCitalac);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dateTimePickerDo);
            this.tabPage2.Controls.Add(this.dateTimePickerOd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1185, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pregled iznajmljivanja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzadji.Location = new System.Drawing.Point(392, 393);
            this.buttonIzadji.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(157, 46);
            this.buttonIzadji.TabIndex = 7;
            this.buttonIzadji.Text = "Izađi";
            this.buttonIzadji.UseVisualStyleBackColor = true;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazi.Location = new System.Drawing.Point(37, 393);
            this.buttonPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(157, 46);
            this.buttonPrikazi.TabIndex = 7;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            this.chart1.Location = new System.Drawing.Point(590, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(591, 443);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(513, 231);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBoxCitalac
            // 
            this.comboBoxCitalac.FormattingEnabled = true;
            this.comboBoxCitalac.Location = new System.Drawing.Point(136, 91);
            this.comboBoxCitalac.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCitalac.Name = "comboBoxCitalac";
            this.comboBoxCitalac.Size = new System.Drawing.Size(412, 24);
            this.comboBoxCitalac.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Čitalac";
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.CustomFormat = "yyyy";
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDo.Location = new System.Drawing.Point(452, 36);
            this.dateTimePickerDo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.ShowUpDown = true;
            this.dateTimePickerDo.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerDo.TabIndex = 2;
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.CustomFormat = "yyyy";
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd.Location = new System.Drawing.Point(259, 36);
            this.dateTimePickerOd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.ShowUpDown = true;
            this.dateTimePickerOd.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerOd.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vremenski period od";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1185, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "O aplikaciji";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1177, 443);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 480);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Biblioteka \"Stevan Sremac\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonJMBG;
        private System.Windows.Forms.Button buttonUpisi;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCitalac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

