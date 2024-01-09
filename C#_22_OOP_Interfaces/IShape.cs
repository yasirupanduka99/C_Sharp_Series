using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__22_OOP_Interfaces
{
    internal interface IShape //interface class only have abstract methods. there are no other methods. should be abstract methods in the interface class.
    {
        //when we create methods in interface class. there are no access modifiers(public, private, protected) has to mention. because all the methods in the interface class will be public default.
        //So all the methods has to be abstract in interface so its not mention in method headers.
        void calculateArea();

        void calculatePerimeter();
    }
}
