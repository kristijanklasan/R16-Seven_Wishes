using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections;

namespace Projekt_Seven_Wishes
{
    public partial class Moj_dan : Form
    {
        public static string Tekst = "";
        public static string zahtjev = ""; 
        public static string date;

        // konstruktor 
        public Moj_dan()
        {
            InitializeComponent();
            prijava(); // prikaz korisničkog imena i prezimena na prozoru
        }

        #region Izbornik 
 
        // Izbornik: odabir opcija izbornika. Za svaku opciju, otvara se novi prozor. 

        private void btnMoj_dan(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan dan = new Moj_dan();
            dan.Show(); 
        }

        private void btnOdjava(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show(); 
        }

        private void btnPonude(object sender, EventArgs e)
        {
            this.Hide();
            Ponude ponude = new Ponude();
            ponude.Show(); 
        }

        private void btnNapomena(object sender, EventArgs e)
        {
            this.Hide();
            Napomena napomena = new Napomena();
            napomena.Show(); 
        }

        private void btnLista_zelja(object sender, EventArgs e)
        {
            this.Hide();
            Lista_želja lista = new Lista_želja();
            lista.Show(); 
        }

        private void btnDodaci(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show(); 
        }
        // Briše sadržaj textbox-a za pretragu 
        private void btnClear(object sender, EventArgs e)
        {
            textBox1.Clear(); 

        }

        #endregion

        public int brojac = 0;   // služi za brojanje labela 

        // Prazni textbox u kojega unosimo određenu ponudu. 
        private void tbNaziv_pretrage(object sender, EventArgs e)
        {
            brojac++;

            if (brojac == 1)  // kada korisnik klikne na textbox za unos ponude, početni tekst iz textbox-a se briše.
            {
                textBox1.Text = "";
            }
        }
 
        public void povezi_sa_bazom()
        {
           int vrijednost = 0;  // koristi se kako bi provjerili da li postoji tražena ponuda u bazi 
           string upit = textBox1.ToString();

            zahtjev = textBox1.Text;

            var lista =Baza.BPPonude.Pretraga();
            vrijednost = Baza.BPPonude.broj;

            if (vrijednost == 0)
            {
                MessageBox.Show("Tražena ponuda nije pronađena!");
                textBox1.Text = ""; 
            }

            // Izrada picturebox-ova, te punjenje traženim podacima pretrage ponude (slika i naziv)

            PictureBox[] slika = new PictureBox[999];
            ArrayList array = new ArrayList();

            Label[] labela = new Label[999];

                foreach(var neki in lista)
                {
                // Dodavanje slike u arrayList, nakon toga se slika dodaje iz arrayLista u pictureBox
                    byte[] imgg = neki.Slika; 
                    MemoryStream stream = new MemoryStream(imgg, 0, imgg.Length);
                    stream.Write(imgg, 0, imgg.Length);
                    stream.Position = 0;
                    Image sourceImg = Image.FromStream(stream, true);
                    Bitmap clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height);
                    var copy = Graphics.FromImage(clonedImg);
                    copy.DrawImage(sourceImg, 0, 0);
                    array.Add(clonedImg);

                }
                for (int k = 0; k < vrijednost; k++)
                {
                    // Kreiranje picturebox-ova za ponudu
                    slika[k] = new PictureBox();  
                    slika[k].Name = "image--" + k.ToString();  
                    slika[k].SizeMode = PictureBoxSizeMode.StretchImage;  
                    slika[k].Image = (Image)array[k];   // dodavanje slike iz arrayList-a u pictureBox
                    slika[k].Visible = true;    
                    slika[k].SetBounds(280 + k * 150, 230, 120, 120);  // lokacija pictureBox-a koristeći koordinate 
                    this.Controls.Add(slika[k]);   
                    slika[k].BringToFront();   
                }
                int j = 0; 
                foreach(var podatak in lista)
                {
                    // Kreiranje labela sa tekstom ponude

                    labela[j] = new Label();
                    labela[j].Name = "label-" + j.ToString();
                    labela[j].Font = new Font("Arial", 10, FontStyle.Bold);
                    labela[j].BackColor = Color.YellowGreen;
                    labela[j].Text = podatak.Naziv_ponude; 
                    labela[j].Visible = true;
                    labela[j].SetBounds(280 + j * 150, 220, 120, 15);   // lokacija labele koristeći koordinate 
                    labela[j].AutoSize = false;
                    this.Controls.Add(labela[j]);  

                    labela[j].BringToFront();
                    labela[j].Click += new EventHandler(lb_Click);  

                    j++; 
                }  
        }    
        // kada korisnik klikne na naslov ponude, otvoriti će se novi prozor sa podacima o toj ponudi. 
        void lb_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            Tekst = clickedLabel.Text;

            this.Hide();
            Traženje_ponude prikaz= new Traženje_ponude();
            prikaz.Show();
        }
        // Klikom na ikonu za pretragu, podaci će se pretražiti po nazivu ponude kojeg je korisnik upisao u textbox. 
        private void btnPretraga_ponude(object sender, EventArgs e)
        {
            povezi_sa_bazom();
        }

        #region labela i texbox 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        // Odabir datuma za kojeg želimo pretražiti listu želja odnosno vidjeti ponude za taj dan. 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            clear();

            TextBox txt;
            int brojac = 2;
            date = dateTimePicker1.Text;

            var pretrazi = Baza.BPLista_želja.Pretrazivanje_po_datumu();

            foreach (var c in pretrazi)
            {
                txt = (TextBox)this.Controls["textBox" + brojac];
                txt.Text = c.Naziv_želje;

                brojac++;
            }
        }
        /* Služi za brisanje sadržaja svih textbox-ova vezanog za listu želja kod mojeg dana. 
           Svaki put kada korisnik odabere drugi datum, stare ponude će se izbrisati iz textbox.ova  */
        public void clear()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
        // Prikaz korisničkog imena i prezime na prozoru
        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
    }   
}

