using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        public static Dictionary<int, Animal> Animals = new Dictionary<int, Animal>();
        public static Dictionary<int, Food> Foods = new Dictionary<int, Food>();

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
                            AddFood();
                            break;
                        case 3:
                            AddFoodsToMenu();
                            break;
                        case 4:
                            FeedAnimals();
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

        private static void AddFood()
        {
            Console.WriteLine("Enter Food name - ");
            string name = Console.ReadLine();
            Console.WriteLine("How many calories does it have?");
            int calories = Convert.ToInt32(Console.ReadLine());

            Food food = new Food(name, calories);
            Foods.Add(food.Id, food);
        }

        private static void AddFoodsToMenu()
        {
            ShowAnimals();

            Console.WriteLine("Select animal ID - ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!Animals.ContainsKey(id))
                throw new Exception("Input correct animal id");

            if (!Animals[id].Alive)
                throw new Exception("The animal is dead");
            Console.Clear();

            foreach (var food in Foods.Values)
            {
                Console.WriteLine(food.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Which food do you want to add? ");
            int foodId = Convert.ToInt32(Console.ReadLine());

            if (!Foods.ContainsKey(foodId))
                throw new Exception("Input correct food id");


            Animals[id].AddFoodToMenu(Foods[foodId]);

        }

        private static void ShowAnimals()
        {
            foreach (var animal in Animals.Values)
            {
                animal.Information();
                Console.WriteLine();
            }

        }

        private static void FeedAnimals()
        {
            ShowAnimals();

            Console.WriteLine("Select animal ID - ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!Animals.ContainsKey(id))
                throw new Exception("Input correct animal id");

            Console.Clear();
            Animals[id].ShowMenu();

            Console.WriteLine("Which food do you want to give?");
            int foodId = Convert.ToInt32(Console.ReadLine());

            if (!Foods.ContainsKey(foodId))
                throw new Exception("Input correct food id");

            Animals[id].Feed(Foods[foodId]);
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
           
            Console.WriteLine("Enter stomach size - ");
            int size = Convert.ToInt32(Console.ReadLine());

            CreateAnimal(input, name, dt, gender,size);
        }

        private static void CreateAnimal(int input, string name, DateTime dt, Gender gender, int size)
        {
            Animal animal = null;

            switch (input)
            {
                case 1:
                    animal = new OverlandAnimal(name, dt, gender, size);
                    break;
                case 2:
                    animal = new AquaticAnimal(name, dt, gender, size);
                    break;
                case 3:
                    animal = new BirdAnimal(name, dt, gender, size);
                    break;
                case 4:
                    animal = new ReptileAnimal(name, dt, gender, size);
                    break;
                case 5:
                    animal = new AmphibianAnimal(name, dt, gender, size);
                    break;
                default:
                    throw new Exception("Please enter the correct number");
            }

            Animals.Add(animal.Id, animal);
        }
        
    }
}
