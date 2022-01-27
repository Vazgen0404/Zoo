using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class AmphibianAnimal : Animal, IWalkable, ISwimmable
    {
        public AmphibianAnimal(string name, DateTime dt, Gender gender) 
            : base(name, dt, gender)
        {
            Menu.Add(new Food("Food for amphibians 1",30));
            Menu.Add(new Food("Food for amphibians 2",35));
            Menu.Add(new Food("Food for amphibians 3",40));
        }

        public void swim()
        {
            Console.WriteLine($"{Name} is swimming");

        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
