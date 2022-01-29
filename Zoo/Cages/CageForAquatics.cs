namespace Zoo
{
    class CageForAquatics : Cage
    {
        public CageForAquatics() : base("Cage for Aquatics")
        {
            AnimalType = typeof(AquaticAnimal);

        }
    }
}
