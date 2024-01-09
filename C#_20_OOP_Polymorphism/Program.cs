namespace C_Sharp_20_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Object Oriented Programming | Polymophism ------------ \n\n");

            Person person1 = new Person();
            Student student1 = new Student();

            person1.sleep("Tree-Phase");
            person1.sleep(20);

            Console.WriteLine();

            person1.sample();
            student1.sample();

            Console.ReadLine();
        }
    }
}