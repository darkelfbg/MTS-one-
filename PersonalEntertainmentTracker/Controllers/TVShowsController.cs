using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalEntertainmentTracker.Controllers
{
    public class TVShowsController : Controller
    {
        //
        // GET: /TVShows/
        public ActionResult AddTVShows()
        {
            return View();
        }
        //
        // GET: /TVShows/
        public ActionResult TVShowsLibrary()
        {
            return View();
        }
	}
}