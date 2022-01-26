using System.Collections.Generic;

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