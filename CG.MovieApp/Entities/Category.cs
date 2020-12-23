using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieAppEntity.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FilmCategory> FilmCategories { get; set; }
    }
}
