using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //child class
    internal class Student : Person 
    {
        private int studentId;
        private string studentEmail;
        
        public Student (string name, int age, int studentId, string studentEmail) : base (name, age)
        {
            this.studentId = studentId;
            this.studentEmail = studentEmail;
        }

        public override void display()  
        {
            base.display();
            Console.WriteLine("Student ID:  " + studentId);
            Console.WriteLine("Student Email: " + studentEmail);
        }
    }
}
