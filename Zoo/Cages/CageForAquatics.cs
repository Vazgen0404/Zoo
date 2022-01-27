using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class CageForAquatics : Cage
    {
        public CageForAquatics() : base("Cage for Aquatics")
        {
            AnimalType = typeof(AquaticAnimal);

        }
    }
}
