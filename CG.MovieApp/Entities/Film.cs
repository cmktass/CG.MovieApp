using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieAppEntity.Entities
{
    public class Film
    {
        public int Id { get; set; }

        public string NameTr { get; set; }

        public string NameEn { get; set; }

        public DateTime VisionDate { get; set; }

        public int Time { get; set; }

        public int ImdbScore { get; set; }

        public string Title { get; set; }

        public string Country { get; set; }

        public List<FilmCategory> FilmCategories { get; set; }

        public int Budget { get; set; }

        public int Revenues { get; set; }

        public string ImageUrl { get; set; }

        public string FragmentUrl { get; set; }

        public Director Director { get; set; }

        public int DirectorId { get; set; }

        public List<FilmActor> FilmActors { get; set; }

    }
}
