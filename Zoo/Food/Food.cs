using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Food
    {
        private static int id;
        public int Id { get; set; }

        public string Name { get; set; }

        private int calories;
        public int Calories
        {
            get { return calories; }
            set
            {
                if (value > 0)
                {
                    calories = value;
                }
                else throw new Exception("The calories must be greater then 0");
            }
        }

        public Food(string name, int calories)
        {
            id++;
            Id = id;
            Name = name;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Calories} calories";
        }
    }
}
