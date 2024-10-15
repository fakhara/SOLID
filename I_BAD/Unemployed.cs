using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_BAD
{
     public  class Unemployed : IWorker
     {
        public void Work()
        {
            // An unemployed person doesn't work, but we are forced to implement Work()
            Console.WriteLine("Unemployed person doesn't have a job, but forced to implement Work()!");
        }
        public void Eat()
        {
            // Implementera ätlogik här
            Console.WriteLine("Unemployed person is eating...");
        }
    }
}
