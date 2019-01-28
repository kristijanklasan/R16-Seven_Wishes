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


namespace Projekt_Seven_Wishes.Baza
{
    class BPLista_želja
    {
        public static Database database = new Database(); 
        public static int broj = 1; 
        
        public static void uzmi(List<Model.MLista_želja> želje)
        {
            foreach (var z in želje)
            {
                Dodaj_želju(z);
            }
        }
        // Dodaje želju u bazu 
        public static void Dodaj_želju(Model.MLista_želja želja)
        {
            try
            {
                var db = new Database().otvoridb();
                string query = "insert into Lista_želja(ID_ponude,Naziv_želje,Datum_dodavanja) values(@ID_ponude,@Naziv_želje,@Datum_dodavanja)";
                SQLiteCommand command = new SQLiteCommand(query, db);

                command.Parameters.AddWithValue("@ID_ponude", želja.ID_ponude);
                command.Parameters.AddWithValue("@Naziv_želje", želja.Naziv_želje);
                command.Parameters.AddWithValue("@Datum_dodavanja", želja.Datum_dodavanja);
                
                command.ExecuteNonQuery();
                database.Close_connection();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }  
        }
        // Briše određenu ponudu sa liste želja odnosno iz baze
         public static void Izbrisi_želju(Model.MLista_želja obrisi)
         {
            try
            {
                string kljuc=obrisi.Naziv_želje;

                var db = new Database().otvoridb();

                string query = "delete from Lista_želja where Naziv_želje='"+ kljuc+ "'";
                SQLiteCommand command= new SQLiteCommand(query, db);

                command.ExecuteNonQuery();

                MessageBox.Show("Uspjesno ste obrisali želju pod naziom: " + kljuc);

                database.Close_connection(); 
            
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message); 
            }
         }
        // Prikaz svih želja koje postoje pod određenim datumom koji je odabran na Listi želja
        public static List<Model.MLista_želja> Prikaz_zelja()
        {
            var db = new Database().otvoridb();
            var lista = new List<Model.MLista_želja>();

            string query = "select Naziv_želje from Lista_želja where Datum_dodavanja='" + Lista_želja.tekst + "'";
            SQLiteCommand command = new SQLiteCommand(query, db);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Model.MLista_želja naziv = new Model.MLista_želja();

                naziv.Naziv_želje = (reader["Naziv_želje"].ToString());

                lista.Add(naziv); // punjenje liste sa željama koje odgovaraju datumu 
            }

            database.Close_connection();
            return lista; //vraćanje liste 
        }
        // Prikaz svih želja koje postoje pod određenim datumom koji je odaban na Mojem danu 
        public static List<Model.MLista_želja> Pretrazivanje_po_datumu()
        {
            var db = new Database().otvoridb();
            string query = "select Naziv_želje from Lista_želja where Datum_dodavanja='" + Moj_dan.date + "'";
            SQLiteCommand command = new SQLiteCommand(query, db);

            SQLiteDataReader reader = command.ExecuteReader();

            var lista = new List<Model.MLista_želja>();

            while (reader.Read())
            {
                Model.MLista_želja želja = new Model.MLista_želja();

                želja.Naziv_želje = (reader["Naziv_želje"].ToString());

                lista.Add(želja); 
            }
            database.Close_connection();
            return lista; 
        }
        //Pretraži bazu podataka liste želja po nazivu ponude 
        public static void Provjeri(List<Model.MLista_želja> lista)
        {
            var db = new Database().otvoridb();
            foreach (var r in lista)
            {
                string query = "select Naziv_želje,Datum_dodavanja,ID_ponude from Lista_želja where Naziv_želje='" + r.Naziv_želje + "'and Datum_dodavanja='" + r.Datum_dodavanja + "'";
                SQLiteCommand command = new SQLiteCommand(query, db);
                SQLiteDataReader reader = command.ExecuteReader();

                Model.MLista_želja želja = new Model.MLista_želja();
                broj = reader.StepCount;  // vraća broj redaka u bazi 
            }
            database.Close_connection();
        }
    }
}
