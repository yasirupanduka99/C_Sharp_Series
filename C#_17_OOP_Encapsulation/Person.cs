using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__17_OOP_Encapsulation
{
    internal class Person
    {
        //Properties
        //public variables
        public string name;
        public int age;
        public double height;
        public double weight;

        //private variables
        private string lastname;
        private int id;

        //Getters and Setters for private variable, so then other class can access this private variables through the getters and setters.
        //Access Mutators - Long Method | lastname - Read/Write Form
        public string LastName
        {
            get //Read - Enabled
            {
                return lastname;
            }
            set //Write - Enabled
            {
                lastname = value;
            }
        }

        //Access Mutators - Long Method | id - Read/Write Form
        public int Id
        {
            get //Read - Enable
            {
                return id;
            }
            set //Write - Enabled
            {
                id = value;
            }
        }

        //Access Mutators - Long Method | number - Read Only Form
        private int number;

        public int Number
        {
            get //Read - enabled
            {
                return number;
            }
            private set //Write - Disabled
            {
                //number = value;
            }
        }




        //Methods
        public void eating()
        {
            Console.WriteLine("I'm Eating ... (This is eating method)");
        }

        public void sleeping()
        {
            Console.WriteLine("I'm Sleeping ... (This is sleeping method)");
        }

        //This is what encapsulation means. A class have propeties and methods sperately like a medical capsul.
    }
}
