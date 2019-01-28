using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO; 


namespace Projekt_Seven_Wishes.Baza
{

    class BPNapomena
    {
        public static Database database = new Database();
        public static void unesi(List<Model.MNapomena> nap)
        {
            foreach (var napomena in nap)
            {
                Unos(napomena);
            }
        }
        public static void Sve_izbrisi(List<Model.MNapomena> obrisi)
        {
            foreach (var o in obrisi)
            {
                izbrisi_sve(o);
            }
        }
        public static void update(List<Model.MNapomena> radnja)
        {
            if (Napomena.i == 1)
            {
                foreach (var u in radnja)
                {
                    Update(u);
                }
            }
            else
            {
                foreach(var delete in radnja)
                {
                    Delete(delete); 
                }
            }
        }
        // Unos nove napomene
        public static void Unos(Model.MNapomena napomena)
        {
            var db = new Database().otvoridb();
            string query = "insert into Napomena('ID','Naziv','Opis','Datum_dodavanja') values (@ID,@Naziv,@Opis,@Datum_dodavanja)";
            SQLiteCommand command = new SQLiteCommand(query,db);

            command.Parameters.AddWithValue("@ID", napomena.ID);
            command.Parameters.AddWithValue("@Naziv", napomena.Naziv);
            command.Parameters.AddWithValue("@Opis", napomena.Opis);
            command.Parameters.AddWithValue("@Datum_dodavanja", napomena.Datum_dodavanja);

            command.ExecuteNonQuery();

            database.Close_connection();
        }
        // Brisanje napomene iz baze 
        public static void Delete (Model.MNapomena brisanje)
        {
            var db = new Database().otvoridb();
            SQLiteCommand command = new SQLiteCommand("Delete from Napomena where ID='" + brisanje.ID + "'", db);
            command.ExecuteNonQuery();
 
            database.Close_connection();
            Prikazi_podatke();
        }
        // Ažuriranje sadržaja napomene 
        public static void Update (Model.MNapomena update)
        {
            var db = new Database().otvoridb();
            string query = "UPDATE Napomena SET Naziv=@Naziv,Opis=@Opis,Datum_dodavanja=@Datum_dodavanja where ID='"+update.ID+"'"; 
            SQLiteCommand command = new SQLiteCommand(query, db);

            command.Parameters.AddWithValue("@Naziv", update.Naziv);
            command.Parameters.AddWithValue("@Opis", update.Opis);
            command.Parameters.AddWithValue("@Datum_dodavanja", update.Datum_dodavanja);
            command.Parameters.AddWithValue("@ID", update.ID);

            command.ExecuteNonQuery();
            database.Close_connection();
        }
        // Brisanje svih napomena koje postoje u bazi 
       public static void izbrisi_sve(Model.MNapomena napomena)
        {
            var db = new Database().otvoridb();
            var lista = new List<Model.MNapomena>();
            lista.Add(new Model.MNapomena
            {
                ID = napomena.ID,
                Naziv = napomena.Naziv,
                Opis = napomena.Opis,
                Datum_dodavanja = napomena.Datum_dodavanja
            }); 
            foreach (var r in lista)
            {
                SQLiteCommand command = new SQLiteCommand("Delete from Napomena", db);

                command.ExecuteNonQuery();
            }
            database.Close_connection(); 
        }
        // Prikaz svih napomena koje postoje 
        public static List<Model.MNapomena> Prikazi_podatke()
        {
            var db = new Database().otvoridb();
            List<Model.MNapomena> lista = new List<Model.MNapomena>();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Napomena", db);

            SQLiteDataReader myreader;

            myreader = command.ExecuteReader();

            while (myreader.Read())
            {
                Model.MNapomena napomena = new Model.MNapomena();

                napomena.ID = Convert.ToString(myreader["ID"]);
                napomena.Naziv = (string)myreader["Naziv"];
                napomena.Opis = (string)myreader["Opis"];
                napomena.Datum_dodavanja = Convert.ToDateTime(myreader["Datum_dodavanja"]);
                lista.Add(napomena);
            }

            database.Close_connection();
            return lista;
        }
     }
  }
