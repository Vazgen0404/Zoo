﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class CageForBirds : Cage
    {
        public CageForBirds() : base("Cage for birds")
        {
            AnimalType = typeof(BirdAnimal);

        }
    }
}
