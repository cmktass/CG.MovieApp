using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.UI.Models
{
    public class FilmCategoryModel
    {
        public FilmModel Film { get; set; }

        public int FilmId { get; set; }

        public CategoryModel Category { get; set; }

        public int CategoryId { get; set; }
    }
}
