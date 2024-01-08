namespace c_sharp_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Arrays ------------ \n\n");

            /*int[] marks;
            marks = new int[5];*/

            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Stundent's subject " + i + " marks : ");
                marks[i] = Int32.Parse(Console.ReadLine());

                total = total + marks[i];
            }

            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("subject " + j + " marks : " + marks[j]);
            }

            Console.WriteLine("Total Marks : " + total);


            Console.ReadLine();
        }
    }
}