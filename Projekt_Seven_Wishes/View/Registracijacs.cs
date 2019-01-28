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


namespace Projekt_Seven_Wishes
{
    public partial class Registracijacs : Form
    {
        public Registracijacs()
        {
            InitializeComponent();
        }
       
        private void btnRegistracija(object sender, EventArgs e)
        {
            try
            {
                var lis = new List<Model.MKorisnik>();  // nova lista 
                lis.Add(new Model.MKorisnik() { Ime = txtIme.Text, Prezime = txtPrezime.Text, E_mail = txtE_mail.Text, Lozinka = txtLozinka.Text });  // punjenje nove liste sa podacima iz textBox-ova

                Baza.BPKorisnik.registriraj(lis); // poziva metodu koja sprema podatke novog korisnika u bazu 

                MessageBox.Show("Uspješno ste se registrirali!");

                this.Hide();
                Seven_Wishes_izbornik izbornik = new Seven_Wishes_izbornik();
                izbornik.Show();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
        // Čisti sadržaj textBox-ova 
        public void Clear()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtE_mail.Clear();
            txtLozinka.Clear();

        }
        #region picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region textBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
