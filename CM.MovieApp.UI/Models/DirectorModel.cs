using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CG.MovieApp.UI.Models
{
    public class DirectorModel
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        [StringLength(35,ErrorMessage ="Bu alan 35 max 35 karakter.",MinimumLength =3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(35, ErrorMessage = "Bu alan 35 max 35 karakter.", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        public string ImageUrl { get; set; }

        public DateTime BirthDate { get; set; }

        public List<FilmModel> Films { get; set; }
    }
}
