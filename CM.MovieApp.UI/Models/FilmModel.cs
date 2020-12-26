using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CG.MovieApp.UI.Models
{
    public class FilmModel
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "Bu alana en fazla 50 karakter girilebilir.", MinimumLength = 1)]
        public string NameTr { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        [StringLength(50,ErrorMessage ="Bu alana en fazla 50 karakter girilebilir.",MinimumLength =1)]
        public string NameEn { get; set; }

        public DateTime VisionDate { get; set; }

        [Range(1,500,ErrorMessage ="Bu alan 1 den küçük olamaz.")]
        public int Time { get; set; }

        [Range(0,10,ErrorMessage ="Bu alan 0-10 arasında olmalıdır.")]
        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        public int ImdbScore { get; set; }

        [Required(ErrorMessage ="Bu alan Boş geçilemez.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string Country { get; set; }

        public List<FilmCategoryModel> FilmCategories { get; set; }

        [Range(0,9999999999,ErrorMessage ="Bu alan 0' dan küçük olamaz.")]
        public int Budget { get; set; }
        [Range(0, 9999999999, ErrorMessage = "Bu alan 0' dan küçük olamaz.")]
        public int Revenues { get; set; }

        public string ImageUrl { get; set; }

        public string FragmentUrl { get; set; }

        public DirectorModel Director { get; set; }

        public int DirectorId { get; set; }

        public List<FilmActorModel> FilmActors { get; set; }
    }
}
