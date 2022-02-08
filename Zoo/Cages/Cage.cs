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
        public Employee Employee { get; private set; }
        public Food Food { get; set; }

        private event EventHandler _CameFood;

        public Cage(string desc)
        {
            _id++;
            Id = _id;
            Description = desc;
            Animals = new List<Animal>();
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
        public void AddFood(Food food)
        {
            food.TotalCalories = food.CaloriesPerKilogram * Animals.Count;
            Food = food;
            foreach (var item in _CameFood.GetInvocationList())
            {
                try
                {
                    item.DynamicInvoke(this, new EventArgs());
                }
                catch (Exception)
                {
                }
            }
            //_CameFood?.Invoke(this,new EventArgs());
        }
        public void ReduceFood(int calories)
        {
            Food.TotalCalories -= calories;
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
