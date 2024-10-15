using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_GOOD
{
    internal class UserDisplay
    {
        public static void Display(User user)
        {
            Console.WriteLine($" Namn: { user.Name}, E - post: { user.Email}");
        }
    }
}
