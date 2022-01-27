using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {   
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

                    Console.WriteLine("1.  Create Cage");
                    Console.WriteLine("2.  Create Animal");
                    Console.WriteLine("3.  Create Employee");
                    Console.WriteLine("4.  Look at the Zoo");
                    Console.WriteLine("5.  Information About Animals");
                    Console.WriteLine("6.  Employees");
                    Console.WriteLine();
                    Console.WriteLine("    Please select a number for the menu options ");

                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (input)
                    {
                        case 1:
                            CreateCage();
                            break;
                        case 2:
                            CreateAnimal();
                            break;
                        case 3:
                            CreateEmployee();
                            break;
                        case 4:LookAtTheZoo();
                            break;
                        case 5:InformationAboutAnimals();
                            break;
                        case 6:
                            Employees();
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

        private static void Employees()
        {
            Console.WriteLine("1. Show Employees");
            Console.WriteLine("2. Add Personal Cage");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowEmployees();
                    break;
                case "2":
                    AddPersonalCage();
                    break;
                default:
                    break;
            }
        }

        private static void AddPersonalCage()
        {
            Console.Clear();
            ShowEmployees();
            Console.Write("Input employee ID - ");
            int empID = Convert.ToInt32(Console.ReadLine());

            if (!Zoo.Employees.ContainsKey(empID)) throw new Exception("Id not found");

            ShowCages();
            Console.Write("Input Cage ID - ");
            int cageID = Convert.ToInt32(Console.ReadLine());

            if (!Zoo.Cages.ContainsKey(cageID)) throw new Exception("Id not found");

            if (!Zoo.Employees[empID].PersonalCages.Contains(Zoo.Cages[cageID]))
            {
                Zoo.Employees[empID].AddCustomCage(Zoo.Cages[cageID]);
            }
            else throw new Exception("This Cage is already personal");

        }

        private static void ShowCages()
        {
            Console.Clear();
            foreach (var cage in Zoo.Cages.Values)
            {
                Console.WriteLine(cage.ToString()); 
            }
        }

        private static void ShowEmployees()
        {
            Console.Clear();
            foreach (var employee in Zoo.Employees.Values)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine();
        }

        private static void InformationAboutAnimals()
        {
            foreach (var animal in Zoo.Animals.Values)
            {
                animal.Information();
                Console.WriteLine();
            }
        }

        private static void LookAtTheZoo()
        {
            foreach (var cage in Zoo.Cages.Values)
            {
                Console.WriteLine(cage.ToString()); 
                Console.WriteLine("Animals.");
                foreach (var animal in cage.Animals)
                {
                    Console.WriteLine(animal.ToString()); 
                }
                Console.WriteLine();
            }
        }

        private static void CreateEmployee()
        {
            Employee employee;
            Console.Write("Enter Name - ");
            string name = Console.ReadLine();
            Console.Write("Enter Age - ");
            int age = Convert.ToInt32(Console.ReadLine());
            int type = SelectEmployeeType();
            switch (type)
            {
                case 1:
                    employee = new FeedingEmployee(name, age);
                    break;
                default:
                    throw new Exception("Please input correct type");
            }
            Zoo.Employees.Add(employee.Id, employee);
            Console.WriteLine("The Employee has been successfully created");
        }

        private static int SelectEmployeeType()
        {
            Console.WriteLine("1.Feeding Employee");
            Console.WriteLine();
            Console.WriteLine("Please select employee type");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void CreateAnimal()
        {
            int input = SelectAnimalType();
            if (IsExistCorrespondingCage(input))
            {
                InputDataAndSave(input);
            }
            else throw new Exception("There is no corresponding cage in the zoo");
        }

        private static bool IsExistCorrespondingCage(int input)
        {
            switch (input)
            {
                case 1:
                    foreach (var cage in Zoo.Cages.Values)
                    {
                        if (cage is CageForAmphibians) return true;
                    }
                    return false;
                case 2:
                    foreach (var cage in Zoo.Cages.Values)
                    {
                        if (cage is CageForAquatics) return true;
                    }
                    return false;
                case 3:
                    foreach (var cage in Zoo.Cages.Values)
                    {
                        if (cage is CageForBirds) return true;
                    }
                    return false;
                case 4:
                    foreach (var cage in Zoo.Cages.Values)
                    {
                        if (cage is CageForOverlands) return true;
                    }
                    return false;
                case 5:
                    foreach (var cage in Zoo.Cages.Values)
                    {
                        if (cage is CageForReptiles) return true;
                    }
                    return false;
                default:
                    throw new Exception("Please input correct number");
            }
        }

        private static int SelectAnimalType()
        {
            Console.WriteLine("1.  AmphibianAnimal Animal");
            Console.WriteLine("2.  Aquatic Animal");
            Console.WriteLine("3.  Bird");
            Console.WriteLine("4.  Overland");
            Console.WriteLine("5.  Reptile");
            Console.WriteLine();

            Console.WriteLine("Select Animal type");
            return Convert.ToInt32(Console.ReadLine());          
        }

        private static void CreateCage()
        {
            Cage cage;
            switch (SelectCageType())
            {
                case 1:
                    cage = new CageForAmphibians();
                    break;
                case 2:
                    cage = new CageForAquatics();
                    break;
                case 3:
                    cage = new CageForBirds();
                    break;
                case 4:
                    cage = new CageForOverlands();
                    break;
                case 5:
                    cage = new CageForReptiles();
                    break;
                default:
                    throw new Exception("Please input correct number");
            }
            Zoo.Cages.Add(cage.Id,cage);
            Console.WriteLine("The Cage has been successfully created");
        }

        private static int SelectCageType()
        {
            Console.WriteLine("1.Cage for Amphibians");
            Console.WriteLine("2.Cage for Aquatics");
            Console.WriteLine("3.Cage for Birds");
            Console.WriteLine("4.Cage for Overlands");
            Console.WriteLine("5.Cage for Reptiles");
            Console.WriteLine();
            Console.WriteLine("Select Cage type - ");

            return Convert.ToInt32(Console.ReadLine());
        }
        private static void InputDataAndSave(int input)
        {       
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
            Console.Clear();
            Animal animal = null;
            switch (input)
            {
                case 1:
                    animal = new AmphibianAnimal(name, dt, gender);
                    break;
                case 2:
                    animal = new AquaticAnimal(name, dt, gender);
                    break;
                case 3:
                    animal = new BirdAnimal(name, dt, gender);
                    break;
                case 4:
                    animal = new OverlandAnimal(name, dt, gender);
                    break;
                case 5:
                    animal = new ReptileAnimal(name, dt, gender);
                    break;
            }
            Zoo.Animals.Add(animal.Id, animal);
            PutInTheCage(animal);

            Console.WriteLine("The Animal has been successfully created");
        }

        private static void PutInTheCage(Animal animal)
        {
            foreach (var cage in Zoo.Cages.Values)
            {
                Console.WriteLine(cage.ToString());
            }
            Console.WriteLine();
            Console.Write("Select Cage Id - ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (Zoo.Cages[input].AnimalType == animal.GetType())
            {
                Zoo.Cages[input].Animals.Add(animal);
                animal.Cage = Zoo.Cages[input];
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please input correct cage id");
                PutInTheCage(animal);
            }
        }
    }
}
