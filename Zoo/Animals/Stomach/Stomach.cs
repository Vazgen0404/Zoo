using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private int size;
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0)
                {
                    size = value;
                }
                else
                {
                    throw new Exception("The stomach size must be greater then 0");
                }
            }
        }

        public Stomach(int size)
        {
            Size = size;
            Content = Size;
        }

        public void Fill(Food food)
        {
            if (Content != Size)
            {
                Content += food.Calories;
            }
            else throw new Exception("The animal's stomach is full and does not want to eat");
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
