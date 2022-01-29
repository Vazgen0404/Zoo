using System;
using System.Collections.Generic;

namespace Zoo
{
    static class Zoo
    {
        public static Dictionary<int, Animal> Animals { get; set; }
        public static Dictionary<int, Cage> Cages { get; set; }
        public static Dictionary<int, Employee> Employees { get; set; }
        static Zoo()
        {
            Animals = new Dictionary<int, Animal>();
            Cages = new Dictionary<int, Cage>();
            Employees = new Dictionary<int, Employee>();
        }

        public static void ShowCages()
        {
            Console.Clear();
            foreach (var cage in Cages.Values)
            {
                Console.WriteLine(cage.ToString());
            }
        }
        public static void ShowEmployees()
        {
            Console.Clear();
            foreach (var employee in Employees.Values)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine();
        }
        public static void InformationAboutAnimals()
        {
            foreach (var animal in Zoo.Animals.Values)
            {
                animal.Information();
                Console.WriteLine();
            }
        }
    }
}
