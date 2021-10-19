using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBallApi.Domain.Entity
{
    public class CharacterSpecies
    {
        public int Id { get; set; }
        public int CharacteId { get; set; }
        public int SpecieId { get; set; }
    }
}
