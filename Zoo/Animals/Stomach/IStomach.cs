namespace Zoo
{
    interface IStomach
    {
        int Content { get; set; }
        int Size { get;}
        void Fill(Food food);
        void Digest(ref bool alive);
    }
}