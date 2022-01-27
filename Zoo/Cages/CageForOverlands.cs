using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class CageForOverlands : Cage
    {
        public CageForOverlands() :base("Cage for overlands")
        {
            AnimalType = typeof(OverlandAnimal);

        }
    }
}
