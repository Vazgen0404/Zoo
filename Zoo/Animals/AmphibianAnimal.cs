using System;

namespace Zoo
{
    class AmphibianAnimal : Animal, IWalkable, ISwimmable
    {
        public AmphibianAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(FoodType.FoodForAmphibians);
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
