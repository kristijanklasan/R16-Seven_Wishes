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
    public partial class Karta : Form
    {
        public static int a = 1; 
        public Karta()
        {
            InitializeComponent();
        }

        private void btnPovratak(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show(); 
        }

        // Dodavanje lokacije na kartu

        public void Povuci()
        {
           PictureBox pb;

            /* Kada je jedna lokacija pokazana na karti (korisnik želi prikazati drugu), onda se pomoću for petlje druge ponude skrivaju sa karte, 
            a ostaje ona koju je korisnik zadnju odabrao */

           for(int a=1; a<=18; a++)
            {
                pb = (PictureBox)this.Controls["pictureBox" + a];
                pb.Visible = false;
            }
        }
        #region Gumbi destinacija 
        private void btnHotel_Pula_Click(object sender, EventArgs e)
        {
            Povuci(); 
            pictureBox1.Visible = true; 
        }

        private void btnZlatna_vrata_Click(object sender, EventArgs e)
        {
            Povuci(); 
            pictureBox2.Visible = true; 
        }

        private void btnKapela_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox3.Visible = true; 
        }

        private void btnKamp_Stoja_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox4.Visible = true; 
        }

        private void btnRestoran_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox5.Visible = true; 
        }

        private void btnRestoran_Jupiter_Click(object sender, EventArgs e)
        {
            Povuci(); 
            pictureBox6.Visible = true; 
        }

        private void btnRibarska_koliba_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox7.Visible = true; 
        }

        private void btnHotel_Veli_Jože_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox8.Visible = true; 
        }

        private void btnAugustov_hram_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox9.Visible = true; 
        }

        private void btnHotel_Histria_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox10.Visible = true; 
        }

        private void btnHotel_Brioni_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox11.Visible = true; 
        }

        private void btnKatarina_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox12.Visible = true; 
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox13.Visible = true; 
        }

        private void btnUljanik_riva_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox14.Visible = true; 
        }

        private void btnPlaže_Click(object sender, EventArgs e)
        {
            Povuci();
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }
        private void Karta_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
