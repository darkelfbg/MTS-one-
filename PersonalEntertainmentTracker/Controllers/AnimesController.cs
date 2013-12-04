using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalEntertainmentTracker.Controllers
{
    public class AnimesController : Controller
    {
        //
        // GET: /Animes/
        public ActionResult AddAnimes()
        {
            return View();
        }
        //
        // GET: /Animes/
        public ActionResult AnimesLibrary()
        {
            return View();
        }
	}
}