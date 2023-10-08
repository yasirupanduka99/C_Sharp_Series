namespace C_Sharp_IF_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ IF Else Statement | Conditional Statement ------------ \n");

            double marks;

            Console.Write("Enter Your Marks : ");
            marks = Double.Parse(Console.ReadLine());

            //Adding conditions for user inputs using if else statement
            if (marks <= 100 && marks >= 75) {
                Console.WriteLine("You got a 'A' grade : Great Pass!! ✨");
            }
            else if (marks < 75 && marks >= 65) {
                Console.WriteLine("You got a 'B' grade : Nice Pass!! 🤗");
            }
            else if (marks < 65 && marks >= 55)
            {
                Console.WriteLine("You got a 'C' grade : Good Pass!! 😊");
            }
            else if (marks < 55 && marks >= 45)
            {
                Console.WriteLine("You got a 'D' grade : Near Miss Fail!! 🥶");
            }
            else if (marks < 45 && marks >= 0)
            {
                Console.WriteLine("You got a 'E' grade : Ledgendary Fail!! ☠️");
            }
            else
            {
                Console.WriteLine("Result Not Vaild! : Re-Enter result! 👻");
            }



            Console.ReadLine();
        }
    }
}