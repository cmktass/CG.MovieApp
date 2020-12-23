using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieAppEntity.Entities
{
    public class FilmActor
    {
        public Film Film { get; set; }

        public int FilmId { get; set; }

        public Actor Actor { get; set; }

        public int ActorId { get; set; }
    }
}
