using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Zoo
{
    abstract class Animal
    {
        private static int _id { get; set; }
        public int Id { get; private set; }
        protected string Name { get; set; }

        private DateTime _birthday;
        private DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value.Year > 1900 && value < DateTime.Now)
                {
                    _birthday = value;
                }
                else
                {
                    throw new MyException("Invalid date of birthday", MessageType.Error);
                }
            }
        }
        private Gender Gender { get; set; }
        private IStomach Stomach { get; set; }
        public List<Food> Menu { get; private set; }
        private Cage Cage { get; set; }

        private event Action CallEmployee;

        public bool Alive;
        public Animal(string name, DateTime dt, Gender gender)
        {
            _id++;
            Id = _id;
            Name = name;
            Birthday = dt;
            Gender = gender;
            Stomach = new Stomach();
            Menu = new List<Food>();
            Alive = true;
            SetTimer();
        }

        public void SetCage(Cage cage)
        {
            Cage = cage;
            CallEmployee += Cage.Employee.Function;
        }
        private void SetTimer()
        {
            Timer timer = new Timer(5000);
            timer.Elapsed += GetHungry;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        public void Eat()
        {
            if (Alive)
            {
                Food food = Cage.Plate.Foods.FirstOrDefault(f => CanEat(f));
                if(food == null)
                {
                    MakeSound();
                    return;
                }

                Stomach.Fill(food);
                Cage.RemoveFoodInPlate(food);
            }
            else
            {
                throw new MyException("Animal is died", MessageType.Information);
            }
        }

        private void MakeSound()
        {
            CallEmployee();
        }

        private bool CanEat(Food food)
        {
            return Menu.Contains(food);
        }

        private void GetHungry(object sender, ElapsedEventArgs e)
        {
            Stomach.Digest(ref Alive);
            if (Stomach.Content < 50)
            {
                Eat();
            }
        }

        public void Information()
        {
            Console.WriteLine($"Id - {Id}");
            Console.WriteLine($"Cage Id - {Cage.Id}");
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Birthday - {Birthday.ToShortDateString()}");
            Console.WriteLine($"Gender - {Gender}");
            Console.WriteLine($"Status - " + (Alive ? "Alive" : "Died"));
            Console.WriteLine($"Stomachs Content - {Stomach.Content}");
            Console.WriteLine($"Stomachs Size - {Stomach.Size}");
            Console.WriteLine("Menu.");
            foreach (var food in Menu)
            {
                Console.WriteLine(food.ToString());
            }
        }

        public override string ToString()
        {
            return $"{Id}. {Name} {Birthday.ToShortDateString()} {Gender}";
        }

        public void ShowMenu()
        {
            foreach (var food in Menu)
            {
                food.ToString();
            }
        }
    }
}
