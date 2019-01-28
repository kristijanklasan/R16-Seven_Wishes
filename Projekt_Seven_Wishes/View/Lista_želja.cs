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
    public partial class Lista_želja : Form
    {
        public int broj; // služi za brojanje ponuda (po labelama) koje možemo izbrisati sa liste želja.
        public static string tekst = "";  // služi za prosljeđivanje datuma kojeg korisnik odabire na listi želja kako bi prikazao ponude za taj dan.

        // konstruktor
        public Lista_želja()
        {
            InitializeComponent();
            prijava();  //prikazuje na prozoru ime i prezime korisnika koji koristi aplikaciju 
        }
        // Izbornik -> može se odabrati svaka stavka izbornika Moj_dan, Ponude, Napomena, Lista_želja, Dodaci, Odjava. 
        //Odabirom jedne od opcija izbornika , otvara se odgovarajući prozor
        private void btnMoj_dan(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan dan = new Moj_dan();
            dan.Show();
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

        private void btnLista(object sender, EventArgs e)
        {
            this.Hide();
            Lista_želja lista = new Lista_želja();
            lista.Show();
        }

        private void btnOdjava(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show(); 
        }

        private void btnDodaci(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show();
        }

        // poziva se u konstruktru, služi za prikaz imena i prezimena korisnika
        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
        #region labela
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        #endregion

        // Odabir datuma za kojeg korisnik želi vidjeti ponude, odnosno ono što želi posjetiti taj dan. 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Button_clear();
            string zahtjev = Traženje_ponude.želja;
            Clear();
            Label lab;
            broj = 0; 
            int brojac = 8;
     
            tekst = dateTimePicker1.Text;

            var lista = Baza.BPLista_želja.Prikaz_zelja();
            string prijenos; 
            foreach (var b in lista)
            {
                lab = (Label)this.Controls["label" + brojac];
                prijenos = b.Naziv_želje;
                lab.Text = prijenos; 

                brojac++;
                broj++;
            }
        }
        // Čisti cijelu listu želja odnosno prazni labele.
        private void Clear()
        {
            label8.Text="";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = ""; 
        }

        // Služi za prikaz ikone pomoću koje možemo obrisati određenu ponudu sa liste želja. 
        private void btnIzbrisi_vidljivost(object sender, EventArgs e)
        {
            Button but; 
            for (int j = 8; j <8 + broj; j++) {

                but=(Button)this.Controls["Button" + j];
                but.Visible = true;

            }
        }
        // Skrivanje svih ikona za brisanje pojedinih stavki sve dok korisnik ne klikne na gumb izbrisi.
        private void Button_clear()
        {
            Button but;
            for (int j = 8; j <= 14; j++)
            {
                but = (Button)this.Controls["Button" + j];
                but.Visible = false;
            }
        }
        #region button i picturebox
        //Brisanje pojedine ponude sa liste 

        private void btnIzbrisi8(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();
            rijec.Naziv_želje = label8.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label8.Text = "";
        }

        private void btnIzbrisi9(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();
            rijec.Naziv_želje = label9.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label9.Text = "";
        }

        private void btnIzbrisi10(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();  
            rijec.Naziv_želje = label10.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label10.Text = "";
        }

        private void btnIzbrisi11(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();
            rijec.Naziv_želje = label11.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label11.Text = "";
        }

        private void btnIzbrisi12(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();
            rijec.Naziv_želje = label12.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label12.Text = "";
        }

        private void btnIzbrisi13(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();
            rijec.Naziv_želje = label13.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label13.Text = "";
        }

        private void btnIzbrisi14(object sender, EventArgs e)
        {
            Model.MLista_želja rijec = new Model.MLista_želja();

            rijec.Naziv_želje = label14.Text;

            Baza.BPLista_želja.Izbrisi_želju(rijec);
            label14.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void button15_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
