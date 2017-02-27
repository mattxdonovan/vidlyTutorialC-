using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyTutorial.Models;

namespace vidlyTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        //Attribute routing with REGEX to limit length to 2 and range from 1-12
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}"];

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
           } 
    }