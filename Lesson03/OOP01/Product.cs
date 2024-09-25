using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    //OOP class
    internal class Product
    {
        //1. Property (bắt buộc để private - information hiding)
        private string name;
        private double price;
        private string color;
        private int quantity;
        private int year;

        //2. Method (thông thường để public)
        //2.1 Constructor (hàm tạo)
        public Product () { }   //parameterless constructor
        public Product (string name, double price, string c, int q, int y)  //parameterized constructor
        {
            //nếu tên của biến (thuộc tính) giống với tên của tham số
            //thì cần dùng từ khóa "this"
            this.name = name;
            this.price = price;
            //ngược lại, tên khác nhau thì không cần từ khóa "this"
            color = c;
            quantity = q;
            quantity = y;
        }
        //2.2 Getter (Read)
        public string getName()
        {
            return name;
        }
        public double displayPrice()
        {
            return price;
        }
        //2.3 Setter (Write)
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        //2.4 Custom (User-defined) methods
        public void displayProductDetail ()
        {
            Console.WriteLine("Product name: " + name);
            Console.WriteLine("Product price: $" + price);
            Console.WriteLine("Product color: " + color);
            Console.WriteLine("Product quantity: " + quantity);
            Console.WriteLine("Product year: " + year);
        }
    }
}
