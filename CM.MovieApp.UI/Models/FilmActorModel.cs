using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.UI.Models
{
    public class FilmActorModel
    {
        public FilmModel Film { get; set; }

        public int FilmId { get; set; }

        public ActorModel Actor { get; set; }

        public int ActorId { get; set; }
    }
}
