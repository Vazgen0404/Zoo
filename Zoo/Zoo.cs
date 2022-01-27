using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    static class Zoo
    {
        public static Dictionary<int, Animal> Animals { get; set; }
        public static Dictionary<int, Cage> Cages { get; set; }
        public static Dictionary<int, Employee> Employees { get; set; }
        static Zoo()
        {
            Animals = new Dictionary<int, Animal>();
            Cages = new Dictionary<int, Cage>();
            Employees = new Dictionary<int, Employee>();
        }
    }
}
