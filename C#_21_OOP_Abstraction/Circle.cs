using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__21_OOP_Abstraction
{
    internal class Circle : Shape
    {
        public override void calculateArea() // if you inherite parent class that has abstract. then you have to have use that method in child class. when you use that method in child class you have to override that.
        {
            Console.WriteLine("This is Abstraction!");
        }
    }
}
