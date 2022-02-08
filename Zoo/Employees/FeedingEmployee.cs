using System;
using System.Linq;
using System.Timers;

namespace Zoo
{
    class FeedingEmployee : Employee
    {
        public FeedingEmployee(string name, int age) : base(name, age)
        {

        }

        public override void Function(object sender, EventArgs e)
        {
            if (sender is Cage)
            {
                PutFoodInCage((Cage)sender);
            }
            else
            {
                FeedAnimals();
            }
        }
        private void FeedAnimals()
        {
            foreach (var cage in PersonalCages)
            {
                if (cage.Animals.Count > 0)
                {
                    PutFoodInCage(cage);
                }
            }
        }

        private void PutFoodInCage(Cage cage)
        {
            int foodIndex = new Random().Next(cage.Animals.First().Menu.Count);

            cage.AddFood(new Food(40,cage.Animals.First().Menu[foodIndex]));
        }
    }
}
