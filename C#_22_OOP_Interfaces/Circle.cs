using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__22_OOP_Interfaces
{
    internal class Circle : IShape, IMaths //we can inherite multiple interface class. in abstraction we only can one abstract class inherite.
    {
        //When you use interface you don't need to override method to override abstract method in parent class
        public void calculateArea()
        {
            Console.WriteLine("This is calculate Area Method from IShape interface class");
        }

        public void calculatePerimeter()
        {
            Console.WriteLine("This is calculate Perimeter Method from IShape interface class");
        }

        public void calculateMaths()
        {
            Console.WriteLine("This is calculate Maths Method from IMaths interface class");
        }
    }
}
