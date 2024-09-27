using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Mobile
    {
        //1. Attributes (Variables) : private
        private string brand;
        private string model;
        private double price;

        //2. Behaviours (Methods) : public
        //2.1 Constructor
        public Mobile (string brand, string model, double price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        } 
        //2.2 Getter (READ) : string, int, double, float,....
        public string getModel()
        {
            return model;
        }

        public double displayPrice()
        {
            return price;
        }

        //2.3 Setter (WRITE) : void only
        public void setPrice (double price)
        {
            this.price = price;
        }

        //2.4 Custom/User-Defined methods
        public void showDetail()
        {
            Console.WriteLine(brand + " " + model + " - $" + price);
        }
    }
}
