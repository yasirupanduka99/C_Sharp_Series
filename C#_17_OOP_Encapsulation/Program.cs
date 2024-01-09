using C__17_OOP_Encapsulation;

namespace C_Sharp_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n ------------ Object Oriented Programming | Encapsulation ------------ \n\n");

            //Creating Objects from Person class
            Person person1 = new Person();
            Person person2 = new Person();

            //Access Person class Properties
            person1.name = "Yasiru";
            person1.age = 22;
            person1.weight = 50.0;
            person1.height = 6.0;

            person1.LastName = "Panduka";
            person1.Id = 1;

            person2.name = "Kasun";
            person2.age = 23;
            person2.weight = 55;
            person2.height = 5.7;

            person2.LastName = "Premod";
            person2.Id = 2;


            //Access Person class Methods
            person1.eating();
            person1.sleeping();

            person2.eating();
            person2.sleeping();

            Console.WriteLine("\n---Person 1 Details---\n");

            Console.WriteLine("Person1 Id     : " + person1.Id);
            Console.WriteLine("Person1 Name   : " + person1.name + " " + person1.LastName);
            Console.WriteLine("Person1 Age    : " + person1.age + " Years");
            Console.WriteLine("Person1 Weight : " + person1.weight + " Kg");
            Console.WriteLine("Person1 Height : " + person1.height + " Feet");

            Console.WriteLine("\n\n---Person 2 Details---\n");

            Console.WriteLine("Person2 Id     : " + person2.Id);
            Console.WriteLine("Person2 Name   : " + person2.name + " " + person2.LastName);
            Console.WriteLine("Person2 Age    : " + person2.age + " Years");
            Console.WriteLine("Person2 Weight : " + person2.weight + " Kg");
            Console.WriteLine("Person2 Height : " + person2.height + " Feet");

            Console.ReadLine();
        }
    }
}