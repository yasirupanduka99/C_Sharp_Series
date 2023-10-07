namespace C_sharp_Keyboard_Inputs { 
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------- C# Keyboard Input | User Inputs ---------\n");

            //keyboard input or user input mean user can input something (ex: mainly data) to the system

            //declaring variables
            string name;
            int age;
            char letter;

            Console.Write("Enter Your Name : "); //Console.Write dosen't cut down to next line as Console.WriteLine
            name = Console.ReadLine(); //So in here console ask you to type name and when you type name, this statement will run and get your input and save it to name string variable.

            Console.WriteLine("Your Name is " + name); //So you can show input data like this


            Console.Write("\nEnter Your Age : ");
            age = Int16.Parse(Console.ReadLine()); //this is how integer value taken through keyboard input in C#

            Console.WriteLine("Your Age is " + age);


            Console.Write("\nEnter Your Lucky Letter : ");
            letter = Char.Parse(Console.ReadLine()); //this is how char value taken through keyboard input in C#

            Console.WriteLine("Your Lucky Letter is " + letter);


            Console.ReadLine();
        }
    }

}