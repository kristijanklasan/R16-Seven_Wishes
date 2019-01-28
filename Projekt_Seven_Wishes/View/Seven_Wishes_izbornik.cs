using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Projekt_Seven_Wishes
{
    public partial class Seven_Wishes_izbornik : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Seven_Wishes_izbornik()
        {
            InitializeComponent();
        
            player.URL = "Summer.mp3";  // pokretanje pjesme prilikom otvaranja izbornika 
            prijava();  // prikaz korisničkog imena i prezimena na vrhu prozora 
        }
        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            player.controls.play(); 
        }

        // nastavlja sa pjesmom 
        private void btnPlay(object sender, EventArgs e)
        {
            player.controls.play();
        }
        // pauziranje pjesme
        private void btnPause(object sender, EventArgs e)
        {
            player.controls.pause();
        }
        // stopiranje pjesme
        private void btnStop(object sender, EventArgs e)
        {
            player.controls.stop();
        }
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

        private void btnLista_želja(object sender, EventArgs e)
        {
            this.Hide();
            Lista_želja lista = new Lista_želja();
            lista.Show(); 
        }
    }
}
