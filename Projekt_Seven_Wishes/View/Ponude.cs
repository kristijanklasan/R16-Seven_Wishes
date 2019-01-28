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
    public partial class Ponude : Form
    {
        public static string SetValueForText1 = ""; 
        public static string vrijednost = ""; 
        public int brojac = 0;
        public int broj;

        public Ponude()
        {
            InitializeComponent();
            prijava(); // prikaz korisničkog imena i prezimena u prozoru
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
            Ponude ponude = new Ponude();
            ponude.Show();
        }
        private void Odjava(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
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
        // Prikaz korisničkog imena i prezimena na vrhu prozora 
        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }
        #region

        private void pbSlika_zaslona(object sender, EventArgs e)
        {
            
        }
        #endregion
        // prikaz padajućeg popisa, korisnik može preko njega odabrati kategoriju za koju želi vidjeti njene ponude
        public void comboBox(object sender, EventArgs e)
        {
            vrijednost = "";
            vrijednost = comboBox1.Text;

            int broj;
            var lista = Baza.BPPonude.Prikaz_odabranih_ponuda();
            broj = Baza.BPPonude.brojac;  // zapisuje se kolicina ponuda odredene kategorije

            if (broj == 0) // ako u bazi nema ponuda, ispisuje se obavijest da nema ponuda 
            {
                MessageBox.Show("U kategoriji " + comboBox1.Text + "- nema ponuda za prikazati!");
            }
            else
            {
                // Kreiranje picturBox-a, labela te arrayLista za spremanje slike 
                PictureBox[] img = new PictureBox[9999]; 

                Label[] labela = new Label[999];

                ArrayList ar = new ArrayList();

                    foreach (var a in lista)
                    {
                        // Dodavanje slike u picturebox 
                        byte[] imgg = a.Slika;
                        MemoryStream stream = new MemoryStream(imgg, 0, imgg.Length);
                        stream.Write(imgg, 0, imgg.Length);
                        stream.Position = 0;
                        Image sourceImg = Image.FromStream(stream, true);
                        Bitmap clonedImg = new Bitmap(sourceImg.Width, sourceImg.Height);
                        var copy = Graphics.FromImage(clonedImg);
                        copy.DrawImage(sourceImg, 0, 0);
                        ar.Add(clonedImg);
                    }
                    for (int k = 0; k < broj; k++)
                    {
                        // Kreiranje picturebox-ova za ponudu
                        img[k] = new PictureBox();
                        img[k].Name = "image-" + k.ToString();
                        img[k].SizeMode = PictureBoxSizeMode.StretchImage;
                        img[k].Image = (Image)ar[k];
                        img[k].Visible = true;

                    if (k >= 4)  // ako u bazi postoji 4 ili vise ponuda, promijeni koordinatu pictureBox-a 
                    {
                        img[k].SetBounds(300 + 0 * 150, (2) * 180, 120, 120);      
                    }
                    else
                    {
                       img[k].SetBounds(300 + k * 150, 180, 120, 120);
                    }

                       this.Controls.Add(img[k]);
                       img[k].BringToFront();

                       img[k].Click += new EventHandler(pb_Click);  
                    }

                    int j = 0;
                    // kreiranje labela 
                    foreach (var c in lista)
                    {
                       labela[j] = new Label();
                       labela[j].Name = "label-" + j.ToString();
                       labela[j].Font = new Font("Arial", 10, FontStyle.Bold);
                       labela[j].BackColor = Color.YellowGreen;
                       labela[j].Text = c.Naziv_ponude;
                       labela[j].Visible = true;
                    if (j >= 4)  // ukoliko postoji 4 ili više ponuda, promijeni koordinate labela 
                    {    
                       labela[j].SetBounds(300 + 0 * 150, 2 * 180, 120, 15);                          
                    }

                    else
                    {    
                       labela[j].SetBounds(300 + j * 150, 180, 120, 15);    
                    }
                       labela[j].AutoSize = false;
                       this.Controls.Add(labela[j]);

                       labela[j].BringToFront();
                       SetValueForText1 = labela[j].Text;

                       labela[j].Click += new EventHandler(lb_Click);
                       j++;
                    }
                }
            }
        // ukliko korisnik klikne na labelu odnosno na naziv ponude, otvara se novi prozor koji prikazuje sadržaj ponude
        void lb_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            SetValueForText1 = clickedLabel.Text;
            this.Hide();
            Prikaz_ponuda prikaz = new Prikaz_ponuda();
            prikaz.Show();
        }
        // ako korisnik klikne na sliku ponude, ispisuje se poruka 
        void pb_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            MessageBox.Show("Kliknite na naziv ponude ako želite pogledati podatke o ponudi!", "Obavijest"); 
        }

        // očisti sve pnude koje se nalaze na zaslonu 
        private void btnOcisti_zaslon(object sender, EventArgs e)
        {  
            this.Hide();
            Ponude ponuda = new Ponude();
            ponuda.Show();
        }

        private void btnDodaci(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show(); 
        }

        private void btnDodaj_ponudu(object sender, EventArgs e)
        { 
            this.Hide();
            Dodavanje_ponuda ponuda = new Dodavanje_ponuda();
            ponuda.Show();
        }
    }
  }
