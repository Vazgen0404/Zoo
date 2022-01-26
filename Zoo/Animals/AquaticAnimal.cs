using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class AquaticAnimal : Animal, ISwimmable
    {
        public AquaticAnimal(string name, DateTime dt, Gender gender, int stomachSize) 
            : base(name, dt, gender, stomachSize)
        {
        }

        public void swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }
}
