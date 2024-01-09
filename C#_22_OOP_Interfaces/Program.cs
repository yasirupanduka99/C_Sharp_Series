namespace C__22_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n ------------ Object Oriented Programming | Interfaces ------------ \n\n");

            Circle circle1 = new Circle();

            circle1.calculateArea();
            circle1.calculatePerimeter();
            circle1.calculateMaths();

            Console.ReadLine();
        }
    }
}