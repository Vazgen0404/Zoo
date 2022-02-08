using System;
using System.Collections.Generic;
using System.Timers;

namespace Zoo
{
    abstract class Employee
    {
        private int _id;
        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                { _name = value; }
                else throw new MyException("Please input name ",MessageType.Error);
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 18 && value < 60)
                {
                    _age = value;
                }
                else throw new MyException("The age of the employee does not meet the requirements",MessageType.Error);
            }
        }

        public List<Cage> PersonalCages { get; private set; }
        public Employee(string name, int age)
        {
            _id++;
            Id = _id;
            Name = name;
            Age = age;
            PersonalCages = new List<Cage>();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer timer = new Timer(40000);
            timer.Elapsed += Function;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void AddCustomCage(Cage cage)
        {
            PersonalCages.Add(cage);
            cage.SetEmployee(this);
        }
        public abstract void Function(object sender, EventArgs e);
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
