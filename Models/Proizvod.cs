using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Proizvod
    {
        public int Id { get; set; } //dodat
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public int Kolicina { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public string Grad { get; set; }
        public List<Recenzija> ListaRecenzija { get; set; }
        public bool Dostupan { get; set; }
    }
}