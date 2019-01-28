using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Seven_Wishes.Model
{
    class MPonude
    {
        public string Kategorija { get; set; }
        public string Naziv_ponude { get; set; }
        public string Cijena { get; set; }
        public string Adresa { get; set; }
        public string E_mail { get; set; }
        public string Opis { get; set; }
        public string Ocjena { get; set; }
        public DateTime Datum_dodavanja { get; set; }
        public byte[] Slika {get; set;}
        public string ID { get; set; }

    }
 }

