using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieAppEntity.Entities
{
    public class FilmCategory
    {
        public Film Film { get; set; }

        public int FilmId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
