using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public class Kvadrat :IForm
    {
        public int Sida { get; set; }
        public int Area()
        {
            return Sida * Sida;
        }
    }
}
