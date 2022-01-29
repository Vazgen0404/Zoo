namespace Zoo
{
    class CageForReptiles : Cage
    {
        public CageForReptiles() : base("Cage for reptiles")
        {
            AnimalType = typeof(ReptileAnimal);

        }
    }
}
