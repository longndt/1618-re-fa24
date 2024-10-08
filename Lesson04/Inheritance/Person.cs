﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //parent class
    internal class Person
    {
        private string name;
        private int age;

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
