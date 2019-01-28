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
    public partial class Prikaz_ponuda : Form
    {
        string imgLocation = ""; // služi za spremanje lokacije slike 
        public static string naziv = ""; // koristi se za prikaz naziva ponude na vrhu prozora
        public static string datum = ""; // sprema datum ponude 
        public static string ponuda = ""; // sprema naziv destinacije 

        public Prikaz_ponuda()
        {
            InitializeComponent();
            baza();
        }

        public void baza()
        {
            labelPonuda.Text = "Naziv ponude: " + Ponude.SetValueForText1 + ""; 

            string z = Ponude.SetValueForText1;
            txtNaziv_destinacije.Text = z;
            naziv = z;

            var lista = Baza.BPPonude.Prikaz_podataka_o_ponudi();  // čitanje podataka iz baze vezanog za određenu ponudu 

            // punjenje textBox-ova sa podacima iz liste 
            foreach (var a in lista)
            {
                comboBox_Kategorije.Text = a.Kategorija;
                txtNaziv_destinacije.Text = a.Naziv_ponude;
                txtAdresa_destinacije.Text = a.Adresa;
                txtCIjena.Text = a.Cijena;
                txtE_mail_adresa.Text = a.E_mail;
                txtOpis.Text = a.Opis;
                txtOcjena.Text = a.Ocjena;
                txtID_ponude.Text = a.ID; 

                int broj = Convert.ToInt32(txtOcjena.Text);

                PictureBox[] slika = new PictureBox[999]; 

                // Dodavanje slike za ocjenu
                for(int br=0; br<broj; br++)
                {
                    slika[br] = new PictureBox();
                    slika[br].Name = "image-" + br.ToString();
                    slika[br].SizeMode = PictureBoxSizeMode.StretchImage;
                    slika[br].Image= Properties.Resources.zvijezda;
                    slika[br].Visible = true;
                    slika[br].SetBounds(600 + br * 60, 400, 50, 30);
                    this.Controls.Add(slika[br]);
                    slika[br].BringToFront();

                }
                //Dodavanje slike 

                byte[] img = a.Slika; 
                var stream = new MemoryStream(img);
                pictureBox2.Image = Image.FromStream(stream);
            }        
        }
     
        private void btnPonuda(object sender, EventArgs e)
        {
            this.Hide();
            Ponude ponuda = new Ponude();
            ponuda.Show(); 
        }
        // brisanje ponude iz aplikacije 
        private void btnIzbrisi(object sender, EventArgs e)
        {
            try
            {
                var lista = new List<Model.MPonude>();

                lista.Add(new Model.MPonude { Naziv_ponude = txtNaziv_destinacije.Text });  // punjenje liste sa nazivom destinacije

                if (MessageBox.Show("Želite li izbrisati ovu ponudu?", "Potvrdi brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Baza.BPPonude.obrisi(lista); 
                    MessageBox.Show("Ponuda je izbrisana!");

                    this.Hide();
                    Ponude ponuda = new Ponude();
                    ponuda.Show(); 
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
        }      
        // koristi se za ažuriranje svih sadržaja ponude 
        private void btnUpdate(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(stream);
                images = binary.ReadBytes((int)stream.Length); //učitavanje slike 

                var lista = new List<Model.MPonude>();  // nova lista 

                lista.Add(new Model.MPonude   // punjenje liste sa podacima iz textBox-ova
                {
                    ID = txtID_ponude.Text,
                    Kategorija = comboBox_Kategorije.Text,
                    Naziv_ponude = txtNaziv_destinacije.Text,
                    Adresa = txtAdresa_destinacije.Text,
                    Cijena = txtCIjena.Text,
                    E_mail = txtE_mail_adresa.Text,
                    Opis = txtOpis.Text,
                    Slika = images,

                });

                if(MessageBox.Show("Želite li zaista spremiti promjene?","Potvrdi promjenu",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    Baza.BPPonude.update(lista); // poziva metodu za update ponude 
                    MessageBox.Show("Promjene su spremljene!"); 
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
        }
        // koristi se za dodavanje ponude na listu želja 
        private void btnLista(object sender, EventArgs e)
        {
            try
            {
                datum = dateTimePicker1.Text;
                ponuda = txtNaziv_destinacije.Text; 
                var lista3 = new List<Model.MLista_želja>();  // nova lista 

                lista3.Add(new Model.MLista_želja  //punjenje liste sa određenim podacima kao što su: ocjena,d datum, naziv destinacije  
                {
                    ID_ponude = txtOcjena.Text,
                    Datum_dodavanja = dateTimePicker1.Text,
                    Naziv_želje = txtNaziv_destinacije.Text
                });

                Baza.BPLista_želja.Provjeri(lista3);  // poziv metode za provjeru ponuda koje se nalaze na listi želja 
                foreach (var r in lista3)
                { 
                    if (Baza.BPLista_želja.broj == 0) // dodaje ponudu na listu želja ukoliko nema te iste ponude na listi pod istim datumom 
                    {
                      Baza.BPLista_želja.uzmi(lista3); //poziva metodu koja će odati ponudu na listu želja
                      MessageBox.Show("Ponuda je dodana na listu!");
       
                     }
                    else
                    {
                        MessageBox.Show("Ponuda je već stavljena na Vašu listu!", "Obavijest");
                       
                    }
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
        }
        // koristi se za promijenu slike ponude
        private void btnPromijeni(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation;
            }

        }
        #region textbox, labele i picturebox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void labelPonuda_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
