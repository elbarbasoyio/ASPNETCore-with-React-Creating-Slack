using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieViewModel
    {
        [Required(ErrorMessage ="El nombre es un campo requerido")]
        [MaxLength(50, ErrorMessage ="El texto es demasiado largo")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El genero es un campo requerido")]
        [MaxLength(30, ErrorMessage = "El texto es demasiado largo")]
        public string Genre { get; set; }
    }
}
