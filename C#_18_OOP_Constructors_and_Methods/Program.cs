namespace C_Sharp_constructors_and_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Object Oriented Programming | Constructors and Methods ------------ \n\n");

            //Object person1 with default constructor
            Person person1 = new Person();

            //Object person2 with Overloaded Constructor
            Person person2 = new Person("Maths", 75);

            Console.WriteLine("Subject : " + person2.subject);
            Console.WriteLine("Grade   : " + person2.grade);

            person1.studying(); //calling the method or invoking the method

            Console.ReadLine();
        }
    }
}