using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class CageForReptiles : Cage
    {
        public CageForReptiles() : base ("Cage for reptiles")
        {
            AnimalType = typeof(ReptileAnimal);

        }
    }
}
