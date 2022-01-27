using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        public static Dictionary<int, Animal> Animals = new Dictionary<int, Animal>();


        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        public static void ShowMainMenu()
        {
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("1.  Add Animal");
                    Console.WriteLine("2.  Add Food");
                    Console.WriteLine("3.  Add food to the animal menu");
                    Console.WriteLine("4.  Feed Animals");
                    Console.WriteLine("5.  Show Animals");
                    Console.WriteLine("6.  Remove Animal");
                    Console.WriteLine();
                    Console.WriteLine("    Please select a number for the menu options ");

                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (input)
                    {
                        case 1:
                            AddAnimal();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            ShowAnimals();
                            break;
                        case 6:
                            RemoveAnimal();
                            break;
                        default:
                            throw new Exception("Please enter the correct number");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }

            }
        }
        
        private static void ShowAnimals()
        {
            foreach (var animal in Animals.Values)
            {
                animal.Information();
                Console.WriteLine();
            }

        }

      
        private static void RemoveAnimal()
        {
            foreach (var animal in Animals.Values)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Select animal ID - ");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                Animals.Remove(id);
            }
            catch (Exception)
            {

                Console.WriteLine("Please input correct id");
            }

        }

        private static void AddAnimal()
        {
            Console.WriteLine("Select the type");
            Console.WriteLine("1.  OverLand Animal");
            Console.WriteLine("2.  Aquatic Animal");
            Console.WriteLine("3.  Bird");
            Console.WriteLine("4.  Reptail");
            Console.WriteLine("5.  AmphibianAnimal");

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name - ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Birthday");
            Console.WriteLine("Year - ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month - ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day - ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime dt = new DateTime(year, month, day);

            Console.WriteLine("Select animal gender");
            Console.WriteLine("1.Male");
            Console.WriteLine("2.Female");
            Gender gender = (Gender)Convert.ToInt32(Console.ReadLine());
           

            CreateAnimal(input, name, dt, gender);
        }

        private static void CreateAnimal(int input, string name, DateTime dt, Gender gender)
        {
            Animal animal = null;

            switch (input)
            {
                case 1:
                    animal = new OverlandAnimal(name, dt, gender);
                    break;
                case 2:
                    animal = new AquaticAnimal(name, dt, gender);
                    break;
                case 3:
                    animal = new BirdAnimal(name, dt, gender);
                    break;
                case 4:
                    animal = new ReptileAnimal(name, dt, gender);
                    break;
                case 5:
                    animal = new AmphibianAnimal(name, dt, gender);
                    break;
                default:
                    throw new Exception("Please enter the correct number");
            }

            Animals.Add(animal.Id, animal);
        }
        
    }
}
