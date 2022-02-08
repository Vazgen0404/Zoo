using System;

namespace Zoo
{
    class BirdAnimal : Animal, IFlyable
    {
        public BirdAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(FoodType.FoodForBirds);
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }
}
