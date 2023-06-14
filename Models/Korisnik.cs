using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Korisnik
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Pol Pol { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Uloga Uloga { get; set; }
        public List<Porudzbina> ListaPorudzbina { get; set; }
        public List<Proizvod> ListaOmiljenihProizvoda { get; set; }
        public List<Proizvod> ListaObjavljenihProizvoda { get; set; }
    }

    public enum Pol
    {
        Muski,
        Zenski
    }

    public enum Uloga
    {
        Kupac,
        Prodavac,
        Administrator
    }

}