using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies/random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        // movies/edit/1
        // movies/edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        // movies
        // movies?pageIndex=1
        // movies?pageIndex=1&sortBy=ReleaseDate
        // movies?sortBy=ReleaseDate
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        // movies/released/2014/04
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}