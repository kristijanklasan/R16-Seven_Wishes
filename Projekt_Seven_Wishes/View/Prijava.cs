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
    public partial class Prijava : Form
    {
        Database database = new Database();
        public Prijava()
        {
            InitializeComponent();
        }

        # region textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnPrijava(object sender, EventArgs e)
        {
            var lista_prijava = new List<Model.MKorisnik>();   // kreiranje nove liste 

            lista_prijava.Add(new Model.MKorisnik { E_mail = txtE_mail.Text, Lozinka = txtLozinka.Text });  // dodavanje u listu sadržaj textBox-ova 
            Baza.BPKorisnik.prijavi(lista_prijava);

            int br = Baza.BPKorisnik.brojac;  // vraca vrijednost 1 ukoliko korisnik postoji u bazi 

            if (br >= 1)
            {
                MessageBox.Show("Uspješno ste se prijavili!");

                this.Hide();
                Seven_Wishes_izbornik izbornik = new Seven_Wishes_izbornik();
                izbornik.Show();
            }
            else if (br == 0)
            {
                MessageBox.Show("Pogriješili ste lozinku!");
                Clear();

            }
        }
        // Čisti sadržaj textBox-ova 
        public void Clear()  
        {
            txtE_mail.Clear();
            txtLozinka.Clear();
        }
    }
}
