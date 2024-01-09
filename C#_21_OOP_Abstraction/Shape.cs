using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__21_OOP_Abstraction
{
    internal abstract class Shape
    {
        public string name;

        //Abstraction Method
        public abstract void calculateArea(); //if there abstract method inside a class then that class have to be abstract also
    }
}
