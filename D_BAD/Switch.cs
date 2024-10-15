using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_BAD
{
    public class Switch
    {

        private LightBulb bulb = new LightBulb();

        public void Toggle()
        {
            if (IsOn())
                bulb.TurnOff();
            else
                bulb.TurnOn();
        }
        public bool IsOn()
        {
            if (bulb.LightOn)
                return true;
            return false;
        }
    }
}
