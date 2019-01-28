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
    public partial class Napomena : Form
    {
        List<Model.MNapomena> plista = new List<Model.MNapomena>();
        public static int i = 0; // služi za prosljeđivanje vrijednosti metodi za update ili delete 
        int brojac = 0;  // koristi se za potrebe kreiranja buttona: edit i delete na dataGridView 

        // konstruktor 
        public Napomena()
        {
            InitializeComponent();
            prijava();  // prikaz korisničkog imena i prezimena
        }
       
        private void edit_button()
        {
            //Kreiranje i dodavanje gumba EDIT na gridview

            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
            editbutton.FlatStyle = FlatStyle.Popup;
            editbutton.HeaderText = "Edit";
            editbutton.Name = "Edit"; 
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "Edit";
            editbutton.Width = 70;
            dataGridView1.Columns.Insert(4,editbutton);
        }

        private void delete_button()
        {
            // Kreiranje i dodavanje gumba DELETE na gridview

            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.HeaderText = "Delete";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Delete";
            deletebutton.Width = 70;
            dataGridView1.Columns.Insert(5,deletebutton);
        }
        public void prijava()
        {
            Model.MKorisnik korisnik = new Model.MKorisnik();
            Baza.BPKorisnik.Prikaz(korisnik);
            lblPrijava.Text = "Prijavljeni ste kao: " + Baza.BPKorisnik.ime + " " + Baza.BPKorisnik.prezime;
        }

        public void prikaz()
        {
            // Prikaz svih napomena iz baze 
            brojac++;

            plista = Baza.BPNapomena.Prikazi_podatke(); // punjenje liste sa napomenama koje se nalaze u bazi 
           
            dataGridView1.DataSource = plista;  // prikaz svih podataka iz liste u tablicu tj. dataGridView

            if (brojac == 1)   // kreiranje buttona delete i update samo jednom tijekom izvođenja aplikacije 
            {
                edit_button();
                delete_button();
            }
        }
        // Eventi 

        private void dataGrid(object sender, DataGridViewCellEventArgs e)
        {
            // update napomena iz dataGridView-a
            if (e.ColumnIndex ==  dataGridView1.Columns["Edit"].Index)
            {
                i = 1; 
                var lista = new List<Model.MNapomena>();

                // punjenje liste sa napomenama koje želimo updatati
                lista.Add(new Model.MNapomena
                {
                    ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Naziv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Opis = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Datum_dodavanja = DateTime.Now

                });
              
                if (MessageBox.Show("Želite li spremiti promjene?", "Potvrdi spremanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    Baza.BPNapomena.update(lista); // update napomena 
                   
                    MessageBox.Show("Promjena je uspješno spremljena!");
                }
            }
            if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                //Odabir napomena koje želimo izbrisati 
                try
                {
                    i = 2;
                    
                    var lista2 = new List<Model.MNapomena>();

                    // for petlja se koristi kako bi se direktno izbrisale napomene iz tablice
                    for (int i = 0; i <= 5; i++)
                    {
                        lista2.Add(new Model.MNapomena
                        {
                            ID = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString()
                        });
                    }
                    if (MessageBox.Show("Želite li izbrisati napomenu", "Potvrdi brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Baza.BPNapomena.update(lista2); // brisanje odabrane napomene 
                        MessageBox.Show("Uspješno ste izbrisali napomenu!", "Obavijest");

                        prikaz(); 
                    }
                    else
                    {
                        this.Hide();
                        Napomena napomena = new Napomena();
                        napomena.Show();
                    }              
                } 
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message); 
                }
            }
        }
        private void btnDodaj_napomenu(object sender, EventArgs e)
        {
            this.Hide();
            Dodavanje_napomene dodaj = new Dodavanje_napomene();
            dodaj.Show(); 
        }
        private void btnOdjava(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show(); 
        }

        #region prikaz
        private void btnPrikaz(object sender, EventArgs e)
        {
            prikaz();
        }
        #endregion

        private void btnBrisanje(object sender, EventArgs e)
        {
            // Brisanje svih napomena koji se nalaze u bazi 
            try
            {
                prikaz(); 
                Baza.BPNapomena.Sve_izbrisi(plista);
                MessageBox.Show("Sve napomene su uspješno izbrisane!");

                this.Hide();
                Napomena nap = new Napomena();
                nap.Show(); 
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
        }
        // Izbornik 
        private void buttonMoj_dan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moj_dan moj = new Moj_dan();
            moj.Show();
        }

        private void buttonPonuda(object sender, EventArgs e)
        {
            this.Hide();
            Ponude ponude = new Ponude();
            ponude.Show();
        }

        private void buttonNapomena_Click(object sender, EventArgs e)
        {
            this.Hide();
            Napomena napomena = new Napomena();
            napomena.Show();
        }

        private void buttonMoja_lista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_želja lista = new Lista_želja();
            lista.Show();
        }

        private void buttonDodaci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodaci dodaci = new Dodaci();
            dodaci.Show();
        }

        #region pb
        private void Napomena_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
