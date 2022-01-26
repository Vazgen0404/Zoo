using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Cage> CustomCages { get; set; }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
            CustomCages = new List<Cage>();
        }

        public void AddCustomCage(Cage cage)
        {
            CustomCages.Add(cage);
        }

        public abstract void Function();
    }
}
