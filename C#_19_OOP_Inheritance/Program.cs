namespace C_Sharp_19_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Object Oriented Programming | Inheritance ------------ \n\n");

            Person person1 = new Person(); //This object was create using parent class(Person). So person1 only can access Person class things.
            Student student1 = new Student(); //This object was create using child class(Student)/ So student1 can access both Person and Student class things because child always inherite parent class.
            Person person2 = new Student(); // This person2 is create Student class but it initiate by Person class. So this person2 only can access parent class.

            person1.name = "Lalitha";
            person1.age = 24;

            student1.name = "Yasiru";
            student1.age = 24;
            student1.studentID = 1;
            student1.universityName = "SLIIT";

            person2.name = "kasun";
            person2.age = 23;

            Console.WriteLine("\n---Person 1 Details---\n");

            Console.WriteLine("Person1 Name : " + person1.name);
            Console.WriteLine("Person1 Age  : " + person1.age);

            Console.WriteLine("\n\n---Student 1 Details---\n");

            Console.WriteLine("Student Name       : " + student1.name);
            Console.WriteLine("Student Age        : " + student1.age);
            Console.WriteLine("Student ID         : " + student1.studentID);
            Console.WriteLine("Student University : " + student1.universityName);

            Console.WriteLine("\n\n---Person 2 Details---\n");

            Console.WriteLine("Person2 Name : " + person2.name);
            Console.WriteLine("Person2 Age  : " + person2.age);


            Console.ReadLine();
        }
    }
}