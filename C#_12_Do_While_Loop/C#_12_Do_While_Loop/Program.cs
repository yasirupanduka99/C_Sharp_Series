using System.Runtime.CompilerServices;

namespace C_Sharp_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n ------------ Do While Loop Statement | Iteration ------------ \n\n");


            int number;
            double total = 0;

            do
            {
                Console.Write("Enter Number : ");
                number = Int32.Parse(Console.ReadLine());

                if (number != -1) 
                {
                    total = total + number;
                }
                else
                {
                    total = total;
                }
                /* This if else statement is for this program shoud be exit when input -1 from keyboard.
                   but in do-while loop also calculate -1 for the total. it should be if -1 entered only
                   exit the program and show the total thats why this if-else statement here. */
            } while (number != -1);

            Console.Write("Total is " + total);


            Console.ReadLine();
        }
    }
}