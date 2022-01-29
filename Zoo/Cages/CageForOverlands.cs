namespace Zoo
{
    class CageForOverlands : Cage
    {
        public CageForOverlands() : base("Cage for overlands")
        {
            AnimalType = typeof(OverlandAnimal);

        }
    }
}
