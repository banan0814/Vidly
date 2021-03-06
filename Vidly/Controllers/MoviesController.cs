﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return  new List<Movie>
            {
                new Movie {Id=1,Name = "valami" },
                new Movie {Id = 2,Name = "másik film"}
            };
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            var customers = new List<Costumer>
            {
                new Costumer {Name = "Customer 1"},
                new Costumer {Name = "Customer 2"}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Costumers = customers

            };

            return View(viewModel);
           
        }
    }
}