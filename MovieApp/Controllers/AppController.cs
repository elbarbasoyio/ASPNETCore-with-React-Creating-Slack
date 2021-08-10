using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        private static List<MovieViewModel> _movies = new List<MovieViewModel>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model)
        {
            if(ModelState.IsValid)
            {
                _movies.Add(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
