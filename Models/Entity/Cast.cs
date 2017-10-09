using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models.Entity
{
    public class Cast
    {
        public int CastId { get; set; }

        //Navigation properties
        /*public ICollection<Movie> Movies { get; set; }
        public ICollection<Actor> Actors { get; set; }*/
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

    }
}
