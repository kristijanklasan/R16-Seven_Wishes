using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Seven_Wishes.Baza
{
    class BPKorisnik
    {
        public static Database database = new Database(); 
        public static string ime = "";
        public static string prezime = "";

        // Unos novog korisnika u bazu 
        public static void regUnos(Model.MKorisnik registriraj)
        {
            var db = new Database().otvoridb();
            string query = "insert into Registracija('Ime','Prezime','E_mail','Lozinka') values (@Ime,@Prezime,@E_mail,@Lozinka)";
            SQLiteCommand command = new SQLiteCommand(query, db);

            command.Parameters.AddWithValue("@Lozinka", registriraj.Lozinka);
            command.Parameters.AddWithValue("@Ime", registriraj.Ime);
            command.Parameters.AddWithValue("@Prezime", registriraj.Prezime);
            command.Parameters.AddWithValue("@E_mail", registriraj.E_mail);

            ime = registriraj.Ime;
            prezime = registriraj.Prezime;

            command.ExecuteNonQuery();
            database.Close_connection();
        }

        public static void registriraj(List<Model.MKorisnik> reg)
        {
            foreach (var a in reg)
            {
                regUnos(a);
            }
        }

        public static int brojac = 0;

        public static void prijavi(List<Model.MKorisnik> log)
        {
            foreach (var prijava in log)
            {
                Prikaz(prijava);
            }
        }
        // Provjeri da li korisnik postoji
        public static void Prikaz(Model.MKorisnik prijava)
        {
            try
            {
                var db = new Database().otvoridb();
                string query = "Select * from Registracija where E_mail='" + prijava.E_mail + "'and Lozinka='" + prijava.Lozinka + "'";
                SQLiteCommand command = new SQLiteCommand(query, db);

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Model.MKorisnik prijave = new Model.MKorisnik(); 
                    prijave.Ime = (string)reader["Ime"];
                    prijave.Prezime=(string)reader["Prezime"];

                    ime = prijave.Ime;
                    prezime = prijave.Prezime; 
                    brojac++;
                }

                database.Close_connection();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
    }
}
