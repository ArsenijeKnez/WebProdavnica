using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Proizvodi
    {
        public static List<Proizvod> ListaProizvoda { get; set; } = new List<Proizvod>()
        {
            new Proizvod() { Id = 1, Naziv = "Orbit Zvake", Cena= 42, Kolicina=23, DatumPostavljanja = new DateTime(2022, 1, 1), Dostupan= true, Grad= "Novi Sad", Opis= "Za zvakanje", Slika ="Slike/zvake.png" },
            new Proizvod() { Id = 2, Naziv = "Vinjak", Cena= 1100, Kolicina=3, DatumPostavljanja = new DateTime(2023, 2, 2), Dostupan= true, Grad= "Novi Sad", Opis= "Za piti", Slika ="Slike/vinjak.jpg"  },
            new Proizvod() { Id = 3, Naziv = "Smoki", Cena= 80, Kolicina=18, DatumPostavljanja = new DateTime(2023, 3, 3), Dostupan= true, Grad= "Novi Sad", Opis= "Za jesti", Slika ="Slike/smoki.png"  },
            new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = new DateTime(2022, 7, 7), Dostupan= true, Grad= "Novi Sad", Opis= "Za grickati", Slika ="Slike/doritos.png"  },
            new Proizvod() { Id = 3, Naziv = "Nesto", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika =" " },
             new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika ="Slike/doritos.png"  },
              new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika ="Slike/doritos.png"  },
               new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika ="Slike/doritos.png"  },
                new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika ="Slike/doritos.png"  },
                 new Proizvod() { Id = 3, Naziv = "Doritos", Cena= 80, Kolicina=18, DatumPostavljanja = DateTime.Now, Dostupan= true, Grad= "Novi Sad", Opis= "...", Slika ="Slike/doritos.png"  }
        };
    }
}