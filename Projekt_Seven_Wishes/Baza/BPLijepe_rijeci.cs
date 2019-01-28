using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Projekt_Seven_Wishes.Baza
{
    class BPLijepe_rijeci
    {
        public static Database database = new Database(); 
        public static int b= 0; 

        public static void unesi(List<Model.MLijepe_rijeci> rijeci)
        {
            foreach (var r in rijeci)
            {
                Unesi(r);
            }
        }
        // Unos novih riječi u bazu 
        public static void Unesi(Model.MLijepe_rijeci words)
        {
                var db = new Database().otvoridb();
                string query = "insert into Words(ID,Hrvatski_naziv,Engleski_naziv) values (@ID,@Hrvatski,@Engleski)";
                SQLiteCommand command = new SQLiteCommand(query, db);

                command.Parameters.AddWithValue("@ID", words.ID);
                command.Parameters.AddWithValue("@Hrvatski", words.Hrvatski_naziv);
                command.Parameters.AddWithValue("@Engleski", words.Engleski_naziv);

                command.ExecuteNonQuery();

            database.Close_connection();
        }
        // Prikaz hrvatski riječi iz baze 
        public static List<Model.MLijepe_rijeci> Prikaz_hrv()
        {
            var db = new Database().otvoridb();
            var lista1 = new List<Model.MLijepe_rijeci>();

            string query = "Select Hrvatski_naziv from Words";
            SQLiteCommand command = new SQLiteCommand(query, db);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Model.MLijepe_rijeci rijeci = new Model.MLijepe_rijeci();
            
                rijeci.Hrvatski_naziv = (string)reader["Hrvatski_naziv"];
              
                b++;
                lista1.Add(rijeci);  // pročitane riječi dodaje u listu 
            }
            
            database.Close_connection();
            return lista1;  // vraća listu 
        }
        // Prikaz engleskih riječi
        public static List<Model.MLijepe_rijeci> Prikaz_eng()
        {
            var db = new Database().otvoridb();
            var lista2 = new List<Model.MLijepe_rijeci>();

            string query = "Select Engleski_naziv from Words";
            SQLiteCommand command = new SQLiteCommand(query, db);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Model.MLijepe_rijeci rijeci = new Model.MLijepe_rijeci();

                rijeci.Engleski_naziv = (string)reader["Engleski_naziv"];

                b++;
                lista2.Add(rijeci);
            }

            database.Close_connection();
            return lista2;
        }
    }
}
