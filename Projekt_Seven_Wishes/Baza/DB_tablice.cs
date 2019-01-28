using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; 

namespace Projekt_Seven_Wishes.Baza
{
    class DB_tablice
    {
        public static void db_tablice()
        {
            Database database = new Database();

            database.Open_connection();

            SQLiteCommand cmd = database.moja_konekcija.CreateCommand(); 

            // Kreiraj nove tablice ukoliko one ne postoje u bazi 
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Napomena(
				ID integer primary key,
				Naziv varchar(30),
				Opis varchar(300),
				Datum_dodavanja value)";

            cmd.ExecuteNonQuery();


            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Registracija(
                Lozinka varchar(50),
                Ime varchar(20),
                Prezime varchar(20),
                E_mail varchar(50) primary key )";

            cmd.ExecuteNonQuery();


            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Ponuda(
                Id integer primary key, 
                Kategorija varchar(50),
                Naziv_destinacije varchar(20),
                Cijena real,
                Adresa varchar(50),
                E_mail varchar(50),
                Opis varchar(200),
                Ocjena integer,
                Slika image,
                Datum_dodavanja date)";


            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Lista_želja(
                ID_ponude integer,
                Naziv_želje varchar(50),
                Datum_dodavanja varchar(60),
                FOREIGN KEY(ID_ponude) REFERENCES Ponude(ID))";

            cmd.ExecuteNonQuery();


            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Words(
                ID integer primary key,
                Engleski_naziv varchar(20),
                Hrvatski_naziv varchar(20))"; 

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            database.Close_connection(); 
        }
    }
}
