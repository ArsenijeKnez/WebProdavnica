using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        public List<Proizvod> Get()
        {
            return Proizvodi.ListaProizvoda;
        }

        public void Post([FromBody] Proizvod product)
        {
            product.Id = Proizvodi.ListaProizvoda.Count + 1;
            Proizvodi.ListaProizvoda.Add(product);
        }

        public void Post()
        {

        }
    }
}
