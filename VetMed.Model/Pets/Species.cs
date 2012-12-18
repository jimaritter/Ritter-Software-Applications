using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Pets
{
    class Species : ISpecies
    {
        private readonly ISpecies _species;

        public Species()
        {
            
        }

        public Species(ISpecies species)
        {
            _species = species;
        }
    }
}
