using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog : Animal
    {
        public void chao()
        {
            Console.WriteLine("Toi la cho");
        }
        public void keu()
        {
            Console.WriteLine("Gau Gau");
        }
    }
}
