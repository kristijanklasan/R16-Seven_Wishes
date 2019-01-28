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
    public partial class Dodavanje_ponuda : Form
    {
        public Dodavanje_ponuda()
        {
            InitializeComponent();
        }
        // brisanje fotografije iz prozora 
        private void Brisanje_fotografije(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "";

        }
        #region adresa:lokacije
        private void Adresa_destinacije_labela(object sender, EventArgs e)
        {

        }
        #endregion

        string imgLocation = ""; 

        // Dodavanje slike sa računala u aplikaciju 
        private void btDodaj_sliku(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation; 
            }
        }
        #region 
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnSpremi(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);  // slika se otvara koristeći filestream 
                BinaryReader binary = new BinaryReader(stream);   // BinaryReader se koristi za čitanje binarnih informacija iz streama. 
                images = binary.ReadBytes((int)stream.Length);  //spremanje slike 

                var ponuda = new List<Model.MPonude>(); // nova lista

                // punjenje liste sa podacima iz textbox-ova 
                ponuda.Add(new Model.MPonude
                {  
                    ID = txtID_ponude.Text,
                    Kategorija = comboBoxKategorija.Text,
                    Naziv_ponude = txtNaziv_destinacije.Text,
                    Adresa = txtAdresa_destinacije.Text,
                    Cijena= txtCijena.Text,
                    E_mail = txtE_mail_adresa.Text,
                    Opis = txtOpis.Text,
                    Datum_dodavanja = dateTimePickerDatum_dodavanja.Value,
                    Slika= images,
                    Ocjena= checkedListBox_Ocjena.Text,
                });

                if (MessageBox.Show("Želite spremiti ponudu?", "Potvrdi spremanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Baza.BPPonude.unesi(ponuda);  // unos ponude u bazu 

                    MessageBox.Show("Uspješno ste unijeli ponudu!");

                    this.Hide();
                    Ponude ponude = new Ponude();
                    ponude.Show();
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
        }
        private void btnOdustani(object sender, EventArgs e)
        {
            this.Hide();
            Ponude ponuda = new Ponude();
            ponuda.Show(); 

        }
        #region elementi
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }     
}

