using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Cage
    {
        private static int id;
        public int Id { get; set; }
        public string  Description { get; set; }
        public List<Animal> Animals { get; set; }
        public Type AnimalType { get; set; }
        public Plate Plate { get; set; }
        public Employee Employee { get; set; }

        private event Action CameFood;

        public Cage(string desc)
        {
            id++;
            Id = id;
            Description = desc;
            Animals = new List<Animal>();
            Plate = new Plate();
        }

        public void SetEmployee(Employee employee)
        {
            Employee = employee;
        }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            animal.SetCage(this);
            CameFood += animal.Eat;
        }
        public void AddFoodInPlate(Food food)
        {
            Plate.AddFood(food);
            CameFood();
        }
        public void RemoveFoodInPlate(Food food)
        {
            Plate.RemoveFood(food);
        }
        public override string ToString()
        {
            return $"{Id}. {Description}. Animals Count - {Animals.Count}";
        }
    }
}
