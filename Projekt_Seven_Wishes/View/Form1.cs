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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrijava(object sender, EventArgs e)
        {
            this.Hide(); // skrivanje prošlih prozora
            Prijava prijava = new Prijava();  // nova instanca
            prijava.Show(); // prikazi prozor na koji ste kliknuli
        }

        private void btnRegistriraj(object sender, EventArgs e)
        {
            this.Hide();  
            Registracijacs registriraj = new Registracijacs(); 
            registriraj.Show(); 

        }
        #region pb
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
