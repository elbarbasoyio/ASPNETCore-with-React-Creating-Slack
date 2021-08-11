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
            return View(_movies);
        }

        public IActionResult AddOrEdit(Guid Id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == Id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == model.Id);
            if (ModelState.IsValid)
            {
                if(movie == null)
                {
                    model.Id = Guid.NewGuid();
                    _movies.Add(model);
                }
                else
                {
                    movie.Name = model.Name;
                    movie.Genre = model.Genre;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            _movies.Remove(_movies.FirstOrDefault(m => m.Id == id));
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
