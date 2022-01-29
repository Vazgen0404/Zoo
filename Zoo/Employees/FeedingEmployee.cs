using System;
using System.Linq;

namespace Zoo
{
    class FeedingEmployee : Employee
    {
        public FeedingEmployee(string name, int age) : base(name, age)
        {

        }

        public override void Function()
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
                    cage.AddFoodInPlate(cage.Animals.First().Menu[index]);
                }
            }
        }
    }
}
