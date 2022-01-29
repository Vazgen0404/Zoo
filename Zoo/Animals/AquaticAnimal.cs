using System;

namespace Zoo
{
    class AquaticAnimal : Animal, ISwimmable
    {
        public AquaticAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(new Food("Food for aquatics 1", 30));
            Menu.Add(new Food("Food for aquatics 2", 35));
            Menu.Add(new Food("Food for aquatics 3", 40));
        }

        public void swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }
}
