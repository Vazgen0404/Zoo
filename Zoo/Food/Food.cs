using System;

namespace Zoo
{
    class Food
    {
        private static int _id;
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

        private int _calories;
        public int Calories
        {
            get { return _calories; }
            set
            {
                if (value > 0)
                {
                    _calories = value;
                }
                else throw new MyException("The calories must be greater then 0",MessageType.Error);
            }
        }

        public Food(string name, int calories)
        {
            _id++;
            Id = _id;
            Name = name;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Calories} calories";
        }
    }
}
