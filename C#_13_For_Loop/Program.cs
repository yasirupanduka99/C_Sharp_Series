namespace C_Sharp_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ For Loop Statement | Iteration ------------ \n\n");

            double marks;
            double total = 0;
            double average = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Marks Of Student's Subject " + i + " : ");
                marks = double.Parse(Console.ReadLine());

                total = total + marks;
                average = total / i;
            }

            Console.WriteLine("\n/n ------------ Results ------------ \n");

            Console.WriteLine("Total Marks of Student : " + total);
            Console.WriteLine("Average Marks of Student  : " + average);

            Console.ReadLine();
        }
    }
}