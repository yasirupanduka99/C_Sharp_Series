using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_20_OOP_Polymorphism
{
    internal class Person
    {
        public string name;
        public int age;



        //Overloading Method - Same Method Diffrent parameters can pass.
        public void sleep(string room)
        {
            Console.WriteLine("Person Sleeping Method Triggered! : Person sleeping " + room + " room.");
        }

        public void sleep(int bedSize)
        {
            Console.WriteLine("Person Sleeping Method Triggered! : Bed SIze : " + bedSize);
        }


        //Overriding - this method overloaded in child class(Student class)
        public virtual void sample() //when we override this method first you have to add virtual after public keyword. then you have to add override in override method in child class
        {
            Console.WriteLine("This is PARENT Class");
        }
    }
}
