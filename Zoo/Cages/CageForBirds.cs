namespace Zoo
{
    class CageForBirds : Cage
    {
        public CageForBirds() : base("Cage for birds")
        {
            AnimalType = typeof(BirdAnimal);

        }
    }
}
