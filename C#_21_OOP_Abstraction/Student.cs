using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_19_OOP_Inheritance
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
    }
}
