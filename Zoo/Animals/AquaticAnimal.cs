using System;

namespace Zoo
{
    class AquaticAnimal : Animal, ISwimmable
    {
        public AquaticAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(FoodType.FoodForAquatics);  
        }

        public void swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }
}
