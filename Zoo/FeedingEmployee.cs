using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class FeedingEmployee : Employee
    {
        public FeedingEmployee(string name, int age) : base(name,age)
        {

        }

        public override void Function()
        {
            FeedAnimals();
        }

        private void FeedAnimals()
        {
            
        }
    }
}
