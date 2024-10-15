﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_BAD
{
    public class UserHandler
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Create(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Display()
        {
            Console.WriteLine($"Namn: {Name}, E-post: {Email}");
        }
    }
}
