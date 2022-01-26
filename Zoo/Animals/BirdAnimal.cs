using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class BirdAnimal : Animal, IFlyable
    {
        public BirdAnimal(string name, DateTime dt, Gender gender, int stomachSize) 
            : base(name, dt, gender, stomachSize)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }
}
