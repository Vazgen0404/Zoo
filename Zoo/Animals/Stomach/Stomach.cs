using System;

namespace Zoo
{
    class Stomach : IStomach
    {
        private int _content;
        public int Content
        {
            get { return _content; }
            set
            {
                if (value <= Size && value > 0)
                {
                    _content = value;
                }
                else if (value > Size)
                {
                    _content = Size;
                }
                else { _content = 0; }
            }
        }

        public int Size { get; }

        public Stomach()
        {
            Size = 100;
            Content = Size;
        }

        public void Fill(int calories)
        {
            if (Content != Size)
            {
                Content += calories;
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
