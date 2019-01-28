using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data; 

namespace Projekt_Seven_Wishes.Baza
{
    class BPMoj_dan
    {
        public static Database database = new Database(); 
        public static string želja = ""; 
        public static void prikaz(Model.MMoj_dan dan)
        {

            var db = new Database().otvoridb();
            želja = dan.Naziv_ponude;

            string query = "select Naziv_želje from Lista_želja where Naziv_želje='"+želja+"'";
            SQLiteCommand command = new SQLiteCommand(query, db);

          
            database.Close_connection(); 
        }
    }
}
