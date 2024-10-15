using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public class Rektangel:IForm
    {
        public int Bredd { get; set; }
        public int Höjd { get; set; }
        public int Area()
        {
            return Bredd * Höjd;
        }
    }
}
