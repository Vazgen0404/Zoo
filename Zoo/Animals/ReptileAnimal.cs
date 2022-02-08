using System;

namespace Zoo
{
    class ReptileAnimal : Animal, ICreepy
    {
        public ReptileAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(FoodType.FoodForReptiles);
        }
        public void Crawl()
        {
            Console.WriteLine($"{Name} is crawling");
        }
    }
}
