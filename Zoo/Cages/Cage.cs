using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
