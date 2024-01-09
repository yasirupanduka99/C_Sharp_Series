using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_constructors_and_methods
{
    class Person
    {

        public string name;
        public int age;

        public string subject;
        public int grade;

        //Constructors
        // 1 - Default Constructor - when program initiate this deafult constructor gives values for the properties.
        public Person()
        {

        }

        // 2 - Overloaded Constructor
        public Person(string subject, int grade)
        {
            this.grade = grade;
            this.subject = subject;
        }

        public void studying()
        {
            Console.WriteLine("Studying Method Triggered!");
        }
    }
}
