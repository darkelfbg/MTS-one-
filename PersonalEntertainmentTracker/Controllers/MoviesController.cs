using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalEntertainmentTracker.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        public ActionResult AddMovies()
        {
            return View();
        }
        //
        // GET: /Movies/
        public ActionResult MoviesLibary()
        {
            return View();
        }
	}
}