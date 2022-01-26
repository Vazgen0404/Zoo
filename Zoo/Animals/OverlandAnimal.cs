using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class OverlandAnimal : Animal, IWalkable, IRunnable
    {
        public OverlandAnimal(string name, DateTime dt, Gender gender, int stomachSize) 
            : base(name, dt, gender, stomachSize)
        {
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is Running");

        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is Walking");

        }
    }
}
