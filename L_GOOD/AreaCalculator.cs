using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public  class AreaCalculator
    {
        public int CalculateArea(IForm form) 
        {
            return form.Area();
        }
    }
}
