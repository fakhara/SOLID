using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_BAD
{
    public class Worker : IWorker
    {
        public void Work()
        {
            // Implementera arbetslogik här
            Console.WriteLine("Human is working...");
        }
        public void Eat()
        {
            // Implementera ätlogik här
            Console.WriteLine("Human is eating lunch...");
        }
    }
}
