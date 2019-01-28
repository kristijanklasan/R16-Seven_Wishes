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
    public partial class Dodavanje_napomene : Form
    {
        public Dodavanje_napomene()
        {
            InitializeComponent();
        }

       #region 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion

        private void btnUnos_napomene(object sender, EventArgs e)
        {
            var lista_napomena = new List<Model.MNapomena>(); // kreiranje nove lista

            try
            {
                lista_napomena.Add(new Model.MNapomena
                {  // listu punimo sa podacima iz textbox-ova 
                    ID = txtUnos_ID.Text,
                    Naziv = txtUnos_naziva.Text,
                    Opis = txtUnos_opisa.Text,
                    Datum_dodavanja = dateDatum.Value
                });

                Baza.BPNapomena.unesi(lista_napomena);  // sadržaj liste spremamo u bazu

                MessageBox.Show("Napomena je spremljena!");
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }

            this.Hide();
            Napomena napomena = new Napomena();
            napomena.Show();
        }

        private void btnIzbornik(object sender, EventArgs e)
        {
            this.Hide();
           Seven_Wishes_izbornik izbornik = new Seven_Wishes_izbornik();
            izbornik.Show(); 
        }
        #region textBox i dateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
