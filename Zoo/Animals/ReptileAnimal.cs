using System;

namespace Zoo
{
    class ReptileAnimal : Animal, ICreepy
    {
        public ReptileAnimal(string name, DateTime dt, Gender gender)
            : base(name, dt, gender)
        {
            Menu.Add(new Food("Food for reptiles 1", 30));
            Menu.Add(new Food("Food for reptiles 2", 35));
            Menu.Add(new Food("Food for reptiles 3", 40));
        }
        public void Crawl()
        {
            Console.WriteLine($"{Name} is crawling");
        }
    }
}
