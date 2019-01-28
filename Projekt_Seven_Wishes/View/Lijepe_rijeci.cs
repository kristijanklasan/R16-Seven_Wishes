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
using System.Data.SQLite;

namespace Projekt_Seven_Wishes
{
    public partial class Lijepe_rijeci : Form
    {
        public static int brojac= 0; // služi za brisanje teksta iz labela kod pokretanja aplikacije

        // konstruktor 
        public Lijepe_rijeci()
        {
            InitializeComponent();
            
            Prikaz_hrv();  // prikazuje hrvatske riječi na listi
            Prikaz_eng();  // prikazuje engleske riječi na listi 
            prijava();  // prikazuje korisničko ime i prezime na prozoru 
        }
        // Izbornik 
        private void btnMoj_dan(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan dan = new Moj_dan();
            dan.Show(); 
        }

        private void btnPonuda(object sender, EventArgs e)
        {
            this.Hide();
            Ponude ponuda = new Ponude();
            ponuda.Show(); 
        }

        private void btnNapomena(object sender, EventArgs e)
        {
            this.Hide();
            Napomena napomena = new Napomena();
            napomena.Show(); 
        }

        private void btnLista_želja(object sender, EventArgs e)
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

        private void btnOdjava(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show(); 
        }

        private void btnDodavanje_novi_rijeci(object sender, EventArgs e)
        {
            this.Hide();
            Dodavanje_rijeci rijeci = new Dodavanje_rijeci();
            rijeci.Show(); 
        }

        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
        #region button i labela
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void Prikaz_hrv()
        { 
            int broj; 
            if (brojac == 0)  // pri svakom pokretanju izbriši postojeće hrvatske riječi iz labela 
            {
                clear_hrv();
            }
            Label lab;

            var lista = Baza.BPLijepe_rijeci.Prikaz_hrv();  // spremanje hrvatskih riječi u listu
            string ab;
            broj = 1;  // upisu u labele je moguć od labele1
            foreach (var a in lista)  // čitanje podataka iz liste i upisivanje u labele
            {
                if (broj == 5)  // upis hrvatskih riječi u labele završava sa labelom5
                {
                    break; 
                }
              lab = (Label)this.Controls["label" + broj];
              ab = a.Hrvatski_naziv;
              lab.Text = ab;   // upis u labelu
              broj++;
                
            }   
            brojac++; 
        }
        public void Prikaz_eng()
        {
            
            int broj; 
            if (brojac == 0)  // pri svakom pokretanju izbriši postojeće hrvatske riječi iz labela 
            {
                clear_eng();
            }
            Label lab;
            broj = 6;  // upis engleskih riječi kreće od 6 labele

            var lista = Baza.BPLijepe_rijeci.Prikaz_eng();  // spremanje podataka u listu 
            string tekst;

            foreach (var b in lista)  // čitanje podataka iz liste i upisivanje u labele
            {
                if (broj == 10)  // moguć upis riječi do 10 labele 
                {
                    break;
                }
                lab = (Label)this.Controls["label" + broj];
                tekst = b.Engleski_naziv;
                lab.Text = tekst;
                broj++;
            }

            brojac++;
        }
        // Brisanje teksta iz labela 
        public void clear_hrv()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
        public void clear_eng()
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }
        #region picturebox i lijepe_rijeci
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Lijepe_rijeci_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
