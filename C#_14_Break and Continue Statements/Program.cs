namespace C_Sharp_Break_and_Continue_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Break and Continue Statements ------------ \n\n");

            Console.WriteLine("----Break Statement----");
            for(int i = 0; i <10; i++)
            {
                if(i == 4)
                {
                    break; //when i = 4 then loop will break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("\n----Continue Statement----");
            for (int i = 0; i <= 10; i++)
            {
                if(i == 4)
                {
                    continue; //when comes to this statement code will continue but dosent go to console.writeline statement instead of its go to for loop. so 4 not will show in output.
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}