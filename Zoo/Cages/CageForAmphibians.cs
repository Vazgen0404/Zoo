namespace Zoo
{
    class CageForAmphibians : Cage
    {
        public CageForAmphibians() : base("Cage for amphibians")
        {
            AnimalType = typeof(AmphibianAnimal);
        }
    }
}
