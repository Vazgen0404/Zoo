using System;

namespace Zoo
{
    class Stomach : IStomach
    {
        private int content;
        public int Content
        {
            get { return content; }
            set
            {
                if (value <= Size && value > 0)
                {
                    content = value;
                }
                else if (value > Size)
                {
                    content = Size;
                }
                else { content = 0; }
            }
        }

        public int Size { get; }

        public Stomach()
        {
            Size = 100;
            Content = Size;
        }

        public void Fill(Food food)
        {
            if (Content != Size)
            {
                Content += food.Calories;
            }
            else throw new MyException("The animal's stomach is full and does not want to eat",MessageType.Information);
        }

        public void Digest(ref bool alive)
        {
            if (alive)
            {
                Content -= 5;

                if (Content <= 0)
                {
                    alive = false;
                }
            }
        }
    }
}
