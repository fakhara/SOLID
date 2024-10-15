using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_GOOD
{
    public class Worker:IWorker, IEater
    {
        public void Work()
        {
            Console.WriteLine("Worker is working...");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating lunch...");
        }
    }
}
