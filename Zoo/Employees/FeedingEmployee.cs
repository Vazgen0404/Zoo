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
            int index = new Random().Next(cage.Animals.First().Menu.Count);
            for (int i = 0; i < cage.Animals.Count - cage.Plate.Foods.Count; i++)
            {
                cage.AddFoodInPlate(cage.Animals.First().Menu[index]);
            }
        }
    }
}
