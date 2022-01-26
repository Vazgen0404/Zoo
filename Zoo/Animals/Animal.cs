﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Zoo
{
    abstract class Animal
    {
        private static int id { get; set; }
        public int Id { get; private set; }
        protected string Name { get; set; }

        private DateTime birthday;
        private DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value.Year > 1900 && value < DateTime.Now)
                {
                    birthday = value;
                }
                else
                {
                    throw new Exception("Invalid date of birthday");
                }
            }
        }
        private Gender Gender { get; set; }
        private IStomach Stomach { get; set; }
        private List<Food> Menu { get; set; }

        public bool Alive;
        public Animal(string name, DateTime dt, Gender gender, int stomachSize)
        {
            id++;
            Id = id;
            Name = name;
            Birthday = dt;
            Gender = gender;
            Stomach = new Stomach(stomachSize);
            Menu = new List<Food>();
            Alive = true;
            SetTimer();
        }
        private  void SetTimer()
        {
            Timer timer = new Timer(5000);
            timer.Elapsed += GetHungry;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        public void AddFoodToMenu(Food food)
        {
            if (!Menu.Contains(food))
            {
                Menu.Add(food);
            }
            else
            {
                throw new Exception("Food is already exist in menu");
            }
        }

        public void Feed(Food food)
        {
            if (Alive)
            {
                if (CanEat(food))
                {
                    Stomach.Fill(food);
                }
                else
                {
                    throw new Exception("The animal does not eat this food");
                }
            }
            else
            {
                throw new Exception("The animal is dead");
            }

        }

        private bool CanEat(Food food)
        {
            return Menu.Contains(food);
        }

        private void GetHungry(object sender, ElapsedEventArgs e)
        {
            Stomach.Digest(ref Alive);
        }
        
        public void Information()
        {
            Console.WriteLine($"Id - {Id}");
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
            return $"{Id}. {Name} {Birthday.ToShortDateString()} {(Alive ? "Alive" : "Died")} {Gender}";
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