using System;

namespace Zoo
{
    class OverlandAnimal : Animal, IWalkable, IRunnable
    {
        public OverlandAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(FoodType.FoodForOverlands);
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
