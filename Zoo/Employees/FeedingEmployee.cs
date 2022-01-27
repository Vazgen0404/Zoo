using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Zoo
{
    class FeedingEmployee : Employee
    {
        public FeedingEmployee(string name, int age) : base(name,age)
        {

        }

        public override void Function(object sender, ElapsedEventArgs e)
        {
            FeedAnimals();
        }

        private void FeedAnimals()
        {
            foreach (var cage in PersonalCages)
            {
                int index = new Random().Next(cage.Animals.First().Menu.Count);
                for (int i = 0; i < cage.Animals.Count - cage.Plate.Foods.Count; i++)
                {
                    cage.Plate.Foods.Add(cage.Animals.First().Menu[index]);
                }
            }
        }
    }
}
