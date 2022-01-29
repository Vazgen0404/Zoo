using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Zoo
{
    abstract class Employee
    {
        private int id;
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                { name = value; }
                else throw new Exception("Please input name ");
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18 && value < 60)
                {
                    age = value;
                }
                else throw new Exception("The age of the employee does not meet the requirements");
            }
        }

        public List<Cage> PersonalCages { get; set; }
        public Employee(string name, int age)
        {
            id++;
            Id = id;
            Name = name;
            Age = age;
            PersonalCages = new List<Cage>();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer timer = new Timer(40000);
            timer.Elapsed += MethodForTimer;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void AddCustomCage(Cage cage)
        {
            PersonalCages.Add(cage);
            cage.SetEmployee(this);
        }
        public void MethodForTimer(object sender, ElapsedEventArgs e)
        { 
            Function(); 
        }
        public abstract void Function();
        public override string ToString()
        {
            string information = $"{Id}. {Name}    Personal cages - ";
            foreach (var cage in PersonalCages)
            {
                information += $"{cage.Id},";
            }

            return information;
        }
    }
}
