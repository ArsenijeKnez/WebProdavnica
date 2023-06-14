using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebProdavnica.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public IHttpActionResult Post(Korisnik korisnik)
        {
            throw new NotImplementedException();
            //if (user == null)
            //{
            //    return BadRequest();
            //}
            //if (user.Ime == null || user.Ime.Length == 0)
            //{
            //    return BadRequest();
            //}
            //if (user.Prezime == null || user.LastName.Length == 0)
            //{
            //    return BadRequest();
            //}
            //return Ok(Users.AddUser(user));
        }

    }
}