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

namespace Projekt_Seven_Wishes.Baza
{
    class BPPonude
    {
        public static Database database = new Database();
        public static int brojac;
        public static int broj = 0; 
         
        public static void unesi(List<Model.MPonude> pon)
        {
            foreach (var ponuda in pon)
            {
                Unos(ponuda);
            }
        }
        public static void update(List<Model.MPonude> up)
        {
            foreach (var p in up)
            {
                Update(p);
            }
        }
        public static void obrisi(List<Model.MPonude> delete)
        {
            foreach (var o in delete)
            {
                Brisanje(o);
            }
        }
        //Unesi ponudu u bazu 
        public static void Unos(Model.MPonude ponude)
        {
            var db = new Database().otvoridb();
            string query = "insert into Ponuda('ID','Kategorija','Naziv_destinacije','Cijena','Adresa','E_mail','Opis','Ocjena','Datum_dodavanja','Slika') values (@ID,@Kategorija,@Naziv_destinacije,@Cijena,@Adresa,@E_mail,@Opis,@Ocjena,@Datum_dodavanja,@Slika)";
            SQLiteCommand command = new SQLiteCommand(query, db);

            command.Parameters.AddWithValue("@ID", ponude.ID);
            command.Parameters.AddWithValue("@Kategorija",ponude.Kategorija);
            command.Parameters.AddWithValue("@Naziv_destinacije",ponude.Naziv_ponude);
            command.Parameters.AddWithValue("@Cijena", ponude.Cijena);
            command.Parameters.AddWithValue("@Adresa", ponude.Adresa);
            command.Parameters.AddWithValue("@E_mail", ponude.E_mail);
            command.Parameters.AddWithValue("@Opis", ponude.Opis);
            command.Parameters.AddWithValue("@Ocjena", ponude.Ocjena);
            command.Parameters.AddWithValue("@Datum_dodavanja", ponude.Datum_dodavanja);
            command.Parameters.AddWithValue("@Slika",ponude.Slika);

            command.ExecuteNonQuery();
            database.Close_connection(); 
        }
        // Brisanje ponude iz baze 
        public static void Brisanje (Model.MPonude obrisi)
        {
            var db = new Database().otvoridb();
            string query = "Delete from Ponuda where Naziv_destinacije='" +obrisi.Naziv_ponude+"'";
            SQLiteCommand command = new SQLiteCommand(query, db);

            command.ExecuteNonQuery(); 

            database.Close_connection(); 
        }
        // Ažuriranje sadržaja ponude, te spremanje u bazu 
        public static void Update (Model.MPonude update)
        {
            var db = new Database().otvoridb();
            string query = "Update Ponuda SET Kategorija=@Kategorija,Naziv_destinacije=@Naziv_destinacije,Adresa=@Adresa,Cijena=@Cijena,E_mail=@E_mail,Opis=@Opis,Slika=@Slika where ID='"+update.ID+"'";
            SQLiteCommand command = new SQLiteCommand(query,db);

            command.Parameters.AddWithValue("@Kategorija", update.Kategorija);
            command.Parameters.AddWithValue("@Naziv_destinacije", update.Naziv_ponude);
            command.Parameters.AddWithValue("@Cijena", update.Cijena);
            command.Parameters.AddWithValue("@Adresa", update.Adresa);
            command.Parameters.AddWithValue("@E_mail", update.E_mail);
            command.Parameters.AddWithValue("@Opis", update.Opis);
            command.Parameters.AddWithValue("@Slika", update.Slika);
            command.ExecuteNonQuery();

            database.Close_connection(); 
        }
        // Prikaz svih ponuda po kategoriji 
        public static List<Model.MPonude> Prikaz_odabranih_ponuda()
        {
            var db = new Database().otvoridb();
            string zahtjev = "select Slika,Naziv_destinacije from Ponuda where Kategorija='" + Ponude.vrijednost + "'";
            SQLiteCommand command = new SQLiteCommand(zahtjev, db);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(zahtjev, db);

            SQLiteDataReader reader = command.ExecuteReader();
 
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            brojac = ds.Tables[0].Rows.Count;

            var lista = new List<Model.MPonude>();
            while (reader.Read())
            {
                Model.MPonude ponuda = new Model.MPonude();

                ponuda.Slika= (byte[])reader["Slika"];
                ponuda.Naziv_ponude = (string)reader["Naziv_destinacije"];
                lista.Add(ponuda);  // punjenje liste sa sadržajem ponuda 
            }

            database.Close_connection();
            return lista;  //vraćanje liste 
        }
        // Prikaz tražene ponude po nazivu 
        public static List<Model.MPonude> Prikaz_odabranog()
        {
            var db = new Database().otvoridb();
            string zahtjev = "Select * from Ponuda where Naziv_destinacije='" + Traženje_ponude.naziv + "'";
            SQLiteCommand command = new SQLiteCommand(zahtjev, db);

            SQLiteDataReader reader;

            // Čitanje svakog retka
            reader = command.ExecuteReader();

            var lista = new List<Model.MPonude>(); 
            while (reader.Read())
            {
                Model.MPonude ponuda = new Model.MPonude();

                ponuda.ID = Convert.ToString(reader["ID"]);
                ponuda.Kategorija = (string)reader["Kategorija"];
                ponuda.Naziv_ponude = (string)reader["Naziv_destinacije"];
                ponuda.Adresa = (string)reader["Adresa"];
                ponuda.Cijena = Convert.ToString(reader["Cijena"]);
                ponuda.E_mail = (string)reader["E_mail"];
                ponuda.Opis = (string)reader["Opis"];
                ponuda.Ocjena= reader["Ocjena"].ToString(); 
                ponuda.Slika = (byte[])reader["Slika"];
                lista.Add(ponuda); // punjenje liste sa svim sadržajem ponude 
            }
            database.Close_connection();
            return lista; // vraćanje liste 
        }
        // Prikaz tražene ponude po nazivu 
        public static List<Model.MPonude> Prikaz_podataka_o_ponudi()
        {
            var db = new Database().otvoridb();
            string zahtjev = "Select * from Ponuda where Naziv_destinacije='" + Prikaz_ponuda.naziv+ "'";
            SQLiteCommand command = new SQLiteCommand(zahtjev, db);

            SQLiteDataReader reader;

            // Čitanje svakog retka
            reader = command.ExecuteReader();

            var lista = new List<Model.MPonude>();
            while (reader.Read())
            {
                Model.MPonude ponuda = new Model.MPonude();

                ponuda.ID = Convert.ToString(reader["ID"]);
                ponuda.Kategorija = (string)reader["Kategorija"];
                ponuda.Naziv_ponude = (string)reader["Naziv_destinacije"];
                ponuda.Adresa = (string)reader["Adresa"];
                ponuda.Cijena = Convert.ToString(reader["Cijena"]);
                ponuda.E_mail = (string)reader["E_mail"];
                ponuda.Opis = (string)reader["Opis"];
                ponuda.Ocjena = reader["Ocjena"].ToString();
                ponuda.Slika = (byte[])reader["Slika"];
                lista.Add(ponuda);
            }
            database.Close_connection();
            return lista;
        }
        // Pretraži ponude po nazivu destinacije 
        public static List<Model.MPonude> Pretraga()
        {
            var db = new Database().otvoridb();
            string query = "select Slika,Naziv_destinacije from Ponuda where Naziv_destinacije='" + Moj_dan.zahtjev + "'";
            SQLiteCommand command = new SQLiteCommand(query, db);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, db);

            SQLiteDataReader reader=command.ExecuteReader();

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // Broj redova u tablici 
            broj = ds.Tables[0].Rows.Count;
            var lista = new List<Model.MPonude>();

            while (reader.Read())
            {
                Model.MPonude ponuda = new Model.MPonude();

                ponuda.Naziv_ponude = (string)reader["Naziv_destinacije"];
                ponuda.Slika = (byte[])reader["Slika"];

                lista.Add(ponuda);
            }
            database.Close_connection();
            return lista; 
        }
    }
}
