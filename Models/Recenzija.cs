using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Recenzija
    {
        public Proizvod Proizvod { get; set; }
        public string Recenzent { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Slika { get; set; }
    }
}