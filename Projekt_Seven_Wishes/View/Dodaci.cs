using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Seven_Wishes
{
    public partial class Dodaci : Form
    {
        public Dodaci()
        {
            InitializeComponent();
            prijava(); 
        }
        // Izbornik

        private void btnMoj_dan(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan dan = new Moj_dan();
            dan.Show(); 
        }

        private void btnPonude(object sender, EventArgs e)
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

        private void btnWords(object sender, EventArgs e)
        {
            this.Hide();
            Lijepe_rijeci rijeci = new Lijepe_rijeci();
            rijeci.Show(); 
        }

        private void btnKarta(object sender, EventArgs e)
        {
            this.Hide();
            Karta karta = new Karta();
            karta.Show(); 
        }

        // Prikaz korisničkog imena i prezimena na prozoru

        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
    }
}
