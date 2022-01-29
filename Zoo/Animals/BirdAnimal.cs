using System;

namespace Zoo
{
    class BirdAnimal : Animal, IFlyable
    {
        public BirdAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(new Food("Food for birds 1", 30));
            Menu.Add(new Food("Food for birds 2", 35));
            Menu.Add(new Food("Food for birds 3", 40));
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }
}
