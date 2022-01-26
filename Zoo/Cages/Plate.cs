using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Plate
    {
        public List<Food> Foods { get; set; }
        public Plate()
        {
            Foods = new List<Food>();
        }
        public void AddFood(Food food)
        {
            Foods.Add(food);
        }
    }
}
