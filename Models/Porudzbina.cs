using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Porudzbina
    {
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public string Kupac { get; set; }
        public DateTime DatumPorudzbine { get; set; }
        public StatusPorudzbine Status { get; set; }
    }

    public enum StatusPorudzbine
    {
        AKTIVNA,
        IZVRSENA,
        OTKAZANA
    }

}