using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public class Triangel:IForm
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public int Area()
        {
            return (Base * Height) / 2;
        }
    }
}
