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

namespace Projekt_Seven_Wishes
{
    public partial class Traženje_ponude : Form
    {
        public static string želja= "";
        public static string naziv = ""; 
        
        public Traženje_ponude()
        {
            InitializeComponent();
            baza();
        }
        public void baza()
        {
            labelPrikaz_podataka.Text = "Prikaz podataka za ponudu: " + Moj_dan.zahtjev + "";  //učitava naziv ponude, te je ispisuje na vrh prozora
            string z = Moj_dan.Tekst;
            txtNaziv_destinacije.Text = z;
            naziv = z;

            var lista = Baza.BPPonude.Prikaz_odabranog(); //poziva se metoda iz statičke klase koja prikazuje podatke o ponudi

            // Punjenje textBox-ova sa podacima iz liste 
            foreach (var a in lista)
            {
                txtID_ponude.Text = a.ID;
                comboBox_Kategorije.Text = a.Kategorija;
                txtNaziv_destinacije.Text = a.Naziv_ponude;
                txtAdresa_destinacije.Text = a.Adresa;
                txtCijena.Text = a.Cijena;
                txtE_mail_adresa.Text = a.E_mail;
                txtOpis.Text = a.Opis;
                txtOcjena.Text = a.Ocjena;

                int broj = Convert.ToInt32(txtOcjena.Text);

                PictureBox[] slika = new PictureBox[999];

                // Dodavanje slike za ocjenu

                for (int br = 0; br < broj; br++)
                {
                    slika[br] = new PictureBox();
                    slika[br].Name = "image-" + br.ToString();
                    slika[br].SizeMode = PictureBoxSizeMode.StretchImage;
                    slika[br].Image = Properties.Resources.zvijezda;
                    slika[br].Visible = true;
                    slika[br].SetBounds(600 + br * 60, 400, 50, 30);
                    this.Controls.Add(slika[br]);
                    slika[br].BringToFront();

                }
                //Dodavanje slike  u pictureBox
                byte[] img = a.Slika;
                var stream = new MemoryStream(img);
                pictureBox2.Image = Image.FromStream(stream);

            }
        }
        private void btnTrazi(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan trazi = new Moj_dan();
            trazi.Show(); 
        }
        // dodavanje ponuda na listu želja 
        private void btnDodaj_na_listu(object sender, EventArgs e)
        {
            var lista = new List<Model.MLista_želja>(); // nova lista 
            string želja = txtNaziv_destinacije.Text; 
            lista.Add(new Model.MLista_želja   // punjenje liste sa podacima iz textBox-ova
            {
                ID_ponude = txtID_ponude.Text,
                Naziv_želje = txtNaziv_destinacije.Text,
                Datum_dodavanja = dateTimePicker_Datum_rezervacije.Text
            });

            Baza.BPLista_želja.Provjeri(lista);  
            if (Baza.BPLista_želja.broj == 0)  //provjerava da li ponuda već postoji na listi želja 
            {
                Baza.BPLista_želja.uzmi(lista); // dodaje ponudu na litu želja 
                MessageBox.Show("Ponudu " + txtNaziv_destinacije.Text + " ste dodali na listu želja!", "Obavijest");
            }
            else
            {
                MessageBox.Show("Ponuda je već dodana na listu!", "Obavijest"); 
            }
            Model.MMoj_dan moj = new Model.MMoj_dan();

            moj.Naziv_ponude = želja;

            Baza.BPMoj_dan.prikaz(moj);

            this.Hide();
            Moj_dan dan = new Moj_dan();
            dan.Show();
        }
        #region textbox i picturebox

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void labelPrikaz_podataka_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
