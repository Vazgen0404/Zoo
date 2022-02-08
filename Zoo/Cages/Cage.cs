using System;
using System.Collections.Generic;

namespace Zoo
{
    abstract class Cage
    {
        private static int _id;
        public int Id { get; set; }
        private string Description { get; set; }
        public List<Animal> Animals { get; private set; }
        public Type AnimalType { get; set; }
        public Plate Plate { get; private set; }
        public Employee Employee { get; private set; }

        private event EventHandler _CameFood;

        public Cage(string desc)
        {
            _id++;
            Id = _id;
            Description = desc;
            Animals = new List<Animal>();
            Plate = new Plate();
        }

        public void SetEmployee(Employee employee)
        {
            Employee = employee;
            foreach (var animal in Animals)
            {
                animal.CallEmployee += Employee.Function;
            }
        }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            animal.SetCage(this);
            _CameFood += animal.Eat;
        }
        public void AddFoodInPlate(Food food)
        {
            Plate.AddFood(food);
            _CameFood?.Invoke(this,new EventArgs());
        }
        public void RemoveFoodInPlate(Food food)
        {
            Plate.RemoveFood(food);
        }
        public void ShowAnimals()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.ToString());
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"{Id}. {Description}. Animals Count - {Animals.Count}";
        }
    }
}
