namespace Projekt_Seven_Wishes
{
    partial class Napomena
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Napomena));
            this.Dodaj_napomenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaci = new System.Windows.Forms.Button();
            this.buttonMoja_lista = new System.Windows.Forms.Button();
            this.buttonNapomena = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMoj_dan = new System.Windows.Forms.Button();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.seven_WishesDataSet = new Projekt_Seven_Wishes.Seven_WishesDataSet();
            this.sevenWishesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven_WishesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenWishesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dodaj_napomenu
            // 
            this.Dodaj_napomenu.AccessibleName = "Dodavanje_napomene";
            this.Dodaj_napomenu.BackColor = System.Drawing.Color.Indigo;
            this.Dodaj_napomenu.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj_napomenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dodaj_napomenu.Location = new System.Drawing.Point(1122, 653);
            this.Dodaj_napomenu.Name = "Dodaj_napomenu";
            this.Dodaj_napomenu.Size = new System.Drawing.Size(208, 77);
            this.Dodaj_napomenu.TabIndex = 2;
            this.Dodaj_napomenu.Text = "Dodaj napomenu";
            this.Dodaj_napomenu.UseVisualStyleBackColor = false;
            this.Dodaj_napomenu.Click += new System.EventHandler(this.btnDodaj_napomenu);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Minion Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1194, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "Odjava";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOdjava);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button8.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(331, 667);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 63);
            this.button8.TabIndex = 19;
            this.button8.Text = "Prikaži ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnPrikaz);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(510, 667);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(173, 63);
            this.button9.TabIndex = 20;
            this.button9.Text = "Izbriši";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnBrisanje);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(361, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 234);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid);
            // 
            // buttonDodaci
            // 
            this.buttonDodaci.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.buttonDodaci.BackColor = System.Drawing.Color.White;
            this.buttonDodaci.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.botun;
            this.buttonDodaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDodaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodaci.Font = new System.Drawing.Font("Minion Pro", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaci.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDodaci.Location = new System.Drawing.Point(41, 602);
            this.buttonDodaci.Name = "buttonDodaci";
            this.buttonDodaci.Size = new System.Drawing.Size(269, 141);
            this.buttonDodaci.TabIndex = 26;
            this.buttonDodaci.Text = "Dodaci";
            this.buttonDodaci.UseVisualStyleBackColor = false;
            this.buttonDodaci.Click += new System.EventHandler(this.buttonDodaci_Click);
            // 
            // buttonMoja_lista
            // 
            this.buttonMoja_lista.BackColor = System.Drawing.Color.White;
            this.buttonMoja_lista.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.botun;
            this.buttonMoja_lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoja_lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoja_lista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoja_lista.Font = new System.Drawing.Font("Minion Pro", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoja_lista.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMoja_lista.Location = new System.Drawing.Point(41, 475);
            this.buttonMoja_lista.Name = "buttonMoja_lista";
            this.buttonMoja_lista.Size = new System.Drawing.Size(269, 121);
            this.buttonMoja_lista.TabIndex = 25;
            this.buttonMoja_lista.Text = "Moja lista ";
            this.buttonMoja_lista.UseVisualStyleBackColor = false;
            this.buttonMoja_lista.Click += new System.EventHandler(this.buttonMoja_lista_Click);
            // 
            // buttonNapomena
            // 
            this.buttonNapomena.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.buttonNapomena.BackColor = System.Drawing.Color.White;
            this.buttonNapomena.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.botun;
            this.buttonNapomena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNapomena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNapomena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNapomena.Font = new System.Drawing.Font("Minion Pro", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNapomena.ForeColor = System.Drawing.Color.Maroon;
            this.buttonNapomena.Location = new System.Drawing.Point(41, 348);
            this.buttonNapomena.Name = "buttonNapomena";
            this.buttonNapomena.Size = new System.Drawing.Size(269, 121);
            this.buttonNapomena.TabIndex = 24;
            this.buttonNapomena.Text = "Napomena";
            this.buttonNapomena.UseVisualStyleBackColor = false;
            this.buttonNapomena.Click += new System.EventHandler(this.buttonNapomena_Click);
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.botun;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Minion Pro", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(41, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 121);
            this.button3.TabIndex = 23;
            this.button3.Text = "Ponude";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonPonuda);
            // 
            // buttonMoj_dan
            // 
            this.buttonMoj_dan.BackColor = System.Drawing.Color.White;
            this.buttonMoj_dan.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.botun;
            this.buttonMoj_dan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoj_dan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoj_dan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoj_dan.Font = new System.Drawing.Font("Minion Pro", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoj_dan.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMoj_dan.Location = new System.Drawing.Point(41, 94);
            this.buttonMoj_dan.Name = "buttonMoj_dan";
            this.buttonMoj_dan.Size = new System.Drawing.Size(269, 121);
            this.buttonMoj_dan.TabIndex = 22;
            this.buttonMoj_dan.Text = "Moj dan ";
            this.buttonMoj_dan.UseVisualStyleBackColor = false;
            this.buttonMoj_dan.Click += new System.EventHandler(this.buttonMoj_dan_Click);
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.BackColor = System.Drawing.Color.Transparent;
            this.lblPrijava.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijava.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrijava.Location = new System.Drawing.Point(819, 51);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(0, 27);
            this.lblPrijava.TabIndex = 35;
            // 
            // seven_WishesDataSet
            // 
            this.seven_WishesDataSet.DataSetName = "Seven_WishesDataSet";
            this.seven_WishesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sevenWishesDataSetBindingSource
            // 
            this.sevenWishesDataSetBindingSource.DataSource = this.seven_WishesDataSet;
            this.sevenWishesDataSetBindingSource.Position = 0;
            // 
            // Napomena
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Seven_Wishes.Properties.Resources.napomena;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 776);
            this.Controls.Add(this.lblPrijava);
            this.Controls.Add(this.buttonDodaci);
            this.Controls.Add(this.buttonMoja_lista);
            this.Controls.Add(this.buttonNapomena);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMoj_dan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dodaj_napomenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Napomena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seven Wishes";
            this.Load += new System.EventHandler(this.Napomena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven_WishesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenWishesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Dodaj_napomenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDodaci;
        private System.Windows.Forms.Button buttonMoja_lista;
        private System.Windows.Forms.Button buttonNapomena;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMoj_dan;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.BindingSource sevenWishesDataSetBindingSource;
        private Seven_WishesDataSet seven_WishesDataSet;
    }
}