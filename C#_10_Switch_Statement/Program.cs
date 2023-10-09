namespace C_Sharp_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Switch Statement | Conditional Statement ------------ \n");

            //Switch statement is also a type of conditional statemnt

            Console.Write("Enter Number (1 to 7 only allowed) : ");
            int day = Int16.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: 
                    Console.WriteLine("No 1 is Monday");
                    break;
                case 2:
                    Console.WriteLine("No 2 is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("No 3 is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("No 4 is Thursday");
                    break;
                case 5:
                    Console.WriteLine("No 5 is Friday");
                    break;
                case 6:
                    Console.WriteLine("No 6 is Saturday");
                    break;
                case 7:
                    Console.WriteLine("No 7 is Sunday");
                    break;
                default: 
                    Console.WriteLine("Invalid Entered Number");
                    break;
            }


            Console.Write("\nType 'Even' or 'Odd' : ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "even":
                    Console.WriteLine("2, 4, 6, 8, 10");
                    break;
                case "Even":
                    Console.WriteLine("2, 4, 6, 8, 10");
                    break;
                case "EVEN":
                    Console.WriteLine("2, 4, 6, 8, 10");
                    break;
                case "odd":
                    Console.WriteLine("1, 3, 5, 7, 9");
                    break;
                case "Odd":
                    Console.WriteLine("1, 3, 5, 7, 9");
                    break;
                case "ODD":
                    Console.WriteLine("1, 3, 5, 7, 9");
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }



            Console.ReadLine();
        }
    }
}