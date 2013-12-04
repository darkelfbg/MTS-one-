using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalEntertainmentTracker.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/
        public ActionResult AddBooks()
        {
            return View();
        }
        //
        // GET: /Books/
        public ActionResult BooksLibrary()
        {
            return View();
        }
	}
}