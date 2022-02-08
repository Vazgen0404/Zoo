namespace Zoo
{
    interface IStomach
    {
        int Content { get; set; }
        int Size { get;}
        void Fill(int calories);
        void Digest(ref bool alive);
    }
}