using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cat : Animal
    {
        public void chao()
        {
            Console.WriteLine("Toi la meo");
        }
        public void keu()
        {
            Console.WriteLine("Meo Meo");
        }
    }
}
