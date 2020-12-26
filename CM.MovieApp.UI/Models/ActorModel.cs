using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CG.MovieApp.UI.Models
{
    public class ActorModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "Bu alan max 50 karakter.")]
        [MinLength(2, ErrorMessage = "Bu alan min 2 karakter.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "Bu alan max 50 karakter.")]
        [MinLength(2, ErrorMessage = "Bu alan min 2 karakter.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        public string Country { get; set; }

        public DateTime BirthDate { get; set; }

        public List<FilmActorModel> FilmActors { get; set; }

    }
}
