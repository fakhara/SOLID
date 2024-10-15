using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_BAD
{
    public class Rektangel
    {
        public virtual int Bredd { get; set; }
        public virtual int Höjd { get; set; }

        public int Area()
        {
            return Bredd * Höjd;
        }
    }
}
