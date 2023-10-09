namespace C_Sharp_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ While Loop Statement | Iteration ------------ \n");

            int count = 1;

            while (count <= 100) {
                Console.WriteLine(count);
                count++;
            }


            int StCount = 1;
            double mark;
            double total = 0;
            double average;

            while (StCount <= 10)
            {
                Console.Write("Enter Marks of Student " + StCount + " : ");
                mark = Double.Parse(Console.ReadLine());

                total = total + mark;
            }

            average = total/10;
            Console.WriteLine("Total is : " + total);



            Console.ReadLine();
        }
    }
}