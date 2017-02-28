using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyTutorial.Models;
using vidlyTutorial.ViewModels;


namespace vidlyTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

  /*      public ActionResult Index()
        {
            return View();
        }
        */
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },

            };

            var viewModel = new RandomMovieViewModel();
            {
                viewModel.Movie = movie;
                viewModel.Customers = customers;
            };
           /*
            var viewResult = new ViewResult();
            viewResult.ViewData.Model
            */
            return View(viewModel);
        }

        //Attribute routing with REGEX to limit length to 2 and range from 1-12
        /*
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}"];

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
           } 
    }