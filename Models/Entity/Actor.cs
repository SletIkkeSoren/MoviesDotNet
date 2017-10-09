using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models.Entity
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public int ActorAge { get; set; }

        //Navigation prop
        public ICollection<Cast> Casts { get; set; }
    }
}
