using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Projekt_Seven_Wishes
{
    class Database
    {
        public SQLiteConnection moja_konekcija;

        public Database()
        {
            moja_konekcija = new SQLiteConnection("Data source=database.db;");

            // ako nema postojeće baze, kreiraj novu
            if (!File.Exists("./database.db"))
            {
                SQLiteConnection.CreateFile("database.db");
                Console.WriteLine("Konekcija je otvroena");

               Baza.DB_tablice.db_tablice(); 
            }
        }
        // metode za otvaranje i zatvaranje konekcije 
        public void Open_connection()
        {
            if(moja_konekcija.State != System.Data.ConnectionState.Open)
            {
                moja_konekcija.Open();

            }
        }
        public void Close_connection()
        {
            if(moja_konekcija.State  != System.Data.ConnectionState.Closed)
            {
                moja_konekcija.Close(); 
            }
        }
        public SQLiteConnection otvoridb() {
            Database database = new Database();
            database.Open_connection();
            SQLiteConnection conn = new SQLiteConnection(database.moja_konekcija);
            return conn;
        }
    }
}
 