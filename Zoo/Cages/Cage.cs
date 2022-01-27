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
        public List<Animal> Animals { get; set; }
        public Plate Plate { get; set; }

        public Cage()
        {
            id++;
            Id = id;
            Animals = new List<Animal>();
            Plate = new Plate();

        }
    }
}
