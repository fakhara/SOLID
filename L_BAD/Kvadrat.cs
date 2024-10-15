using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_BAD
{
    public class Kvadrat : Rektangel
    {
        public override int Bredd
        {
            set { base.Bredd = base.Höjd = value; }
        }
        public override int Höjd
        {
            set { base.Bredd = base.Höjd = value; }
        }
    }
}
