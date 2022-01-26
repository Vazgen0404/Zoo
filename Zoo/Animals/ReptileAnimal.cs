using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class ReptileAnimal : Animal, ICreepy
    {
        public ReptileAnimal(string name, DateTime dt, Gender gender, int stomachSize)
            : base(name,dt,gender,stomachSize)
        {

        }
        public void Crawl()
        {
            Console.WriteLine($"{Name} is crawling");
        }
    }
}
