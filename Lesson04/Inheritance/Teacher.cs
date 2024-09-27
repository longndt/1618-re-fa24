using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher : Person
    {
        private int teacherId;
        private string teacherEmail;

        public Teacher(string name, int age, int teacherId, string teacherEmail) : base(name, age)
        {
            this.teacherId = teacherId;
            this.teacherEmail = teacherEmail;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Teacher ID:  " + teacherId);
            Console.WriteLine("Teacher Email: " + teacherEmail);
        }
    }
}
