using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet("api/movies")]
        public JsonResult GetMovies()
        {
            return new JsonResult(MoviesDataStore.Current.Movies);
        }
    }
}
