using System.Collections.Generic;

namespace Zoo
{
    abstract class Cage
    {
        private static int id;
        public int Id { get; set; }
        public IEnumerable<Animal> Animals { get; set; }
        public Plate Plate { get; set; }

        public Cage(IEnumerable<Animal> animals)
        {
            id++;
            Id = id;
            Animals = animals;
            Plate = new Plate();

        }
    }
}
