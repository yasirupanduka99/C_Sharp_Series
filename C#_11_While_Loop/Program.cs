namespace C_Sharp_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ While Loop Statement | Iteration ------------ \n\n");

            int count = 1;

            while (count <= 5) {
                Console.WriteLine(count);
                count++;
            }

            Console.WriteLine("\n\n");


            int StCount = 1;
            double mark;
            double total = 0;
            double average;

            while (StCount <= 10)
            {
                Console.Write("Enter Marks of Student " + StCount + " : ");
                mark = Double.Parse(Console.ReadLine());

                total = total + mark;
                StCount++;
            }

            average = total/10;
            Console.WriteLine("\nTotal Students : " + (StCount-1));
            Console.WriteLine("Total Marks    : " + total);
            Console.WriteLine("Average Marks  : " + average);



            Console.ReadLine();
        }
    }
}