using System;

namespace Zoo
{
    class Food
    {
        private static int id;
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                { name = value; }
                else throw new MyException("Please input name ",MessageType.Error);
            }
        }

        private int calories;
        public int Calories
        {
            get { return calories; }
            set
            {
                if (value > 0)
                {
                    calories = value;
                }
                else throw new MyException("The calories must be greater then 0",MessageType.Error);
            }
        }

        public Food(string name, int calories)
        {
            id++;
            Id = id;
            Name = name;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Calories} calories";
        }
    }
}
