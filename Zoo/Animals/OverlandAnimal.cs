using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class OverlandAnimal : Animal, IWalkable, IRunnable
    {
        public OverlandAnimal(string name, DateTime dt, Gender gender) 
            : base(name, dt, gender)
        {
            Menu.Add(new Food("Food for overlands 1", 30));
            Menu.Add(new Food("Food for overlands 2", 35));
            Menu.Add(new Food("Food for overlands 3", 40));
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
