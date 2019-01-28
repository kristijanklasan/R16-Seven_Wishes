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
    public partial class Dodavanje_rijeci : Form
    {
        public Dodavanje_rijeci()
        {
            InitializeComponent();
        }
       
        private void btnSpremi(object sender, EventArgs e)
        {
            try
            {        
                var rijeci = new List<Model.MLijepe_rijeci>();  // nova lista 

                // punjenje liste sa podacima iz textbox-ova: ID, hrvatska i engleska riječ 
                rijeci.Add(new Model.MLijepe_rijeci
                {
                    ID = txtID.Text,
                    Hrvatski_naziv = txtHrvatski_naziv.Text,
                    Engleski_naziv = txtEngleski_naziv.Text,
                });
               
                Baza.BPLijepe_rijeci.unesi(rijeci);   // unos podataka u bazu 

                this.Hide();
                Lijepe_rijeci word = new Lijepe_rijeci();
                word.Show(); 
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btnOdustani(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show();
        }
        #region picturebox
        private void Daodavanje_rijeci_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
