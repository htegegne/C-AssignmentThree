﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
