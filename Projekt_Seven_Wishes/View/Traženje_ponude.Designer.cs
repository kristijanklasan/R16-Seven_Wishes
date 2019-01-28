namespace Projekt_Seven_Wishes
{
    partial class Traženje_ponude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Traženje_ponude));
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_ponude = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.comboBox_Kategorije = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtE_mail_adresa = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtAdresa_destinacije = new System.Windows.Forms.TextBox();
            this.txtNaziv_destinacije = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_Datum_rezervacije = new System.Windows.Forms.DateTimePicker();
            this.labelPrikaz_podataka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 75;
            this.label2.Text = "ID ponude:";
            // 
            // txtID_ponude
            // 
            this.txtID_ponude.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtID_ponude.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_ponude.ForeColor = System.Drawing.Color.White;
            this.txtID_ponude.Location = new System.Drawing.Point(325, 146);
            this.txtID_ponude.Multiline = true;
            this.txtID_ponude.Name = "txtID_ponude";
            this.txtID_ponude.Size = new System.Drawing.Size(375, 34);
            this.txtID_ponude.TabIndex = 74;
            this.txtID_ponude.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1033, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 59);
            this.button4.TabIndex = 73;
            this.button4.Text = "Lista";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnDodaj_na_listu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(728, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 72;
            this.label1.Text = "Ocjena: ";
            // 
            // txtOcjena
            // 
            this.txtOcjena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOcjena.Location = new System.Drawing.Point(814, 446);
            this.txtOcjena.Multiline = true;
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(375, 34);
            this.txtOcjena.TabIndex = 71;
            this.txtOcjena.Visible = false;
            // 
            // comboBox_Kategorije
            // 
            this.comboBox_Kategorije.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.comboBox_Kategorije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Kategorije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Kategorije.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Kategorije.ForeColor = System.Drawing.Color.White;
            this.comboBox_Kategorije.FormattingEnabled = true;
            this.comboBox_Kategorije.Items.AddRange(new object[] {
            "Kultna mjesta/ Znamenitosti",
            "Ugostiteljski obrti ",
            "Smještaj",
            "Plaže",
            "Turističke rute",
            "Ostale ponude"});
            this.comboBox_Kategorije.Location = new System.Drawing.Point(325, 199);
            this.comboBox_Kategorije.Name = "comboBox_Kategorije";
            this.comboBox_Kategorije.Size = new System.Drawing.Size(378, 35);
            this.comboBox_Kategorije.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 36);
            this.label9.TabIndex = 68;
            this.label9.Text = "Kategorija ponude:";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtOpis.Font = new System.Drawing.Font("High Tower Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.ForeColor = System.Drawing.Color.White;
            this.txtOpis.Location = new System.Drawing.Point(325, 446);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(378, 150);
            this.txtOpis.TabIndex = 67;
            this.txtOpis.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtE_mail_adresa
            // 
            this.txtE_mail_adresa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtE_mail_adresa.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE_mail_adresa.ForeColor = System.Drawing.Color.White;
            this.txtE_mail_adresa.Location = new System.Drawing.Point(325, 397);
            this.txtE_mail_adresa.Multiline = true;
            this.txtE_mail_adresa.Name = "txtE_mail_adresa";
            this.txtE_mail_adresa.Size = new System.Drawing.Size(375, 34);
            this.txtE_mail_adresa.TabIndex = 66;
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCijena.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.ForeColor = System.Drawing.Color.White;
            this.txtCijena.Location = new System.Drawing.Point(325, 352);
            this.txtCijena.Multiline = true;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(375, 34);
            this.txtCijena.TabIndex = 65;
            // 
            // txtAdresa_destinacije
            // 
            this.txtAdresa_destinacije.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtAdresa_destinacije.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa_destinacije.ForeColor = System.Drawing.Color.White;
            this.txtAdresa_destinacije.Location = new System.Drawing.Point(325, 298);
            this.txtAdresa_destinacije.Multiline = true;
            this.txtAdresa_destinacije.Name = "txtAdresa_destinacije";
            this.txtAdresa_destinacije.Size = new System.Drawing.Size(375, 34);
            this.txtAdresa_destinacije.TabIndex = 64;
            // 
            // txtNaziv_destinacije
            // 
            this.txtNaziv_destinacije.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNaziv_destinacije.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv_destinacije.ForeColor = System.Drawing.Color.White;
            this.txtNaziv_destinacije.Location = new System.Drawing.Point(325, 249);
            this.txtNaziv_destinacije.Multiline = true;
            this.txtNaziv_destinacije.Name = "txtNaziv_destinacije";
            this.txtNaziv_destinacije.Size = new System.Drawing.Size(375, 34);
            this.txtNaziv_destinacije.TabIndex = 63;
            this.txtNaziv_destinacije.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 36);
            this.label7.TabIndex = 62;
            this.label7.Text = "Opis: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 36);
            this.label6.TabIndex = 61;
            this.label6.Text = "E-mail adresa: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(137, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cijena [kn]: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 36);
            this.label4.TabIndex = 59;
            this.label4.Text = "Adresa destinacije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 36);
            this.label3.TabIndex = 58;
            this.label3.Text = "Naziv destinacije:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox2.Location = new System.Drawing.Point(770, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Minion Pro SmBd", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 77;
            this.button1.Text = "<- Natrag";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnTrazi);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 36);
            this.label8.TabIndex = 79;
            this.label8.Text = "Datum rezervacije: ";
            // 
            // dateTimePicker_Datum_rezervacije
            // 
            this.dateTimePicker_Datum_rezervacije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_Datum_rezervacije.Location = new System.Drawing.Point(328, 619);
            this.dateTimePicker_Datum_rezervacije.Name = "dateTimePicker_Datum_rezervacije";
            this.dateTimePicker_Datum_rezervacije.Size = new System.Drawing.Size(378, 22);
            this.dateTimePicker_Datum_rezervacije.TabIndex = 80;
            this.dateTimePicker_Datum_rezervacije.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelPrikaz_podataka
            // 
            this.labelPrikaz_podataka.AutoSize = true;
            this.labelPrikaz_podataka.BackColor = System.Drawing.Color.Black;
            this.labelPrikaz_podataka.Font = new System.Drawing.Font("Franklin Gothic Heavy", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrikaz_podataka.ForeColor = System.Drawing.Color.White;
            this.labelPrikaz_podataka.Location = new System.Drawing.Point(351, 39);
            this.labelPrikaz_podataka.Name = "labelPrikaz_podataka";
            this.labelPrikaz_podataka.Size = new System.Drawing.Size(526, 44);
            this.labelPrikaz_podataka.TabIndex = 81;
            this.labelPrikaz_podataka.Text = "Prikaz podataka za ponudu: ";
            this.labelPrikaz_podataka.Click += new System.EventHandler(this.labelPrikaz_podataka_Click);
            // 
            // Traženje_ponude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.pula_po_noci;
            this.ClientSize = new System.Drawing.Size(1219, 667);
            this.Controls.Add(this.labelPrikaz_podataka);
            this.Controls.Add(this.dateTimePicker_Datum_rezervacije);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_ponude);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox_Kategorije);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtE_mail_adresa);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtAdresa_destinacije);
            this.Controls.Add(this.txtNaziv_destinacije);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Traženje_ponude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seven Wishes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_ponude;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox_Kategorije;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtE_mail_adresa;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtAdresa_destinacije;
        private System.Windows.Forms.TextBox txtNaziv_destinacije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datum_rezervacije;
        private System.Windows.Forms.Label labelPrikaz_podataka;
    }
}