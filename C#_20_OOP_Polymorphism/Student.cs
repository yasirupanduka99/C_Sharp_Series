using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_20_OOP_Polymorphism
{
    internal class Student : Person
    {
        //Properties
        public int studentID;
        public string universityName;

        //Methods
        public void study()
        {
            Console.WriteLine("\nStudent Studying Method Triggered!");
        }

        //Overriding Method - Override the Method of parent class method.
        public override void sample()
        {
            Console.WriteLine("This is STUDENT Class");
        }
    }
}
