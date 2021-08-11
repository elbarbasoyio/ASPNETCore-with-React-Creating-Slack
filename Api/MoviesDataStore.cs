using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class MoviesDataStore
    {
        public static MoviesDataStore Current { get; } = new MoviesDataStore();
        public List<MovieDto> Movies { get; set; }
        public MoviesDataStore()
        {
            Movies = new List<MovieDto>()
            {
                new MovieDto()
                {
                    Id = 1,
                    Name = "Blade Runner",
                    Description = "Fantastic"
                },
                new MovieDto()
                {
                    Id = 2,
                    Name = "Terminator2",
                    Description = "He'll be back!"
                }
            };
        }
    }
}
