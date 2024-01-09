namespace C__23_Errors_and_ExceptionHandiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Object Oriented Programming | Erros & Exception Handling ------------ \n\n");

            //We create enter integer input from keyboard. program work normaly but when we enter decimal value program will be crashed. So we catch this exception and show instead of crasing program.
            try
            {
                Console.Write("Enter Number : ");
                int number = Int32.Parse(Console.ReadLine());


                Console.WriteLine("your Nummber is : " + number);
            }catch (FormatException e)
            {
                Console.WriteLine("Exception Detected! Error : " + e.Message);
            }


            Console.WriteLine();


            //If there are multiple exception, hadle like this
            int n1 = 0;
            int n2 = 0;
            int div = 0;

            try
            {
                Console.Write("Enter Number 1 : ");
                n1 = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Number 2 : ");
                n2 = Int32.Parse(Console.ReadLine());

                div = n1 / n2;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception Detected! Error : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Detected! Error : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Detected! Error : " + e.Message);
            }

            Console.WriteLine("Division is : " + div);
            

            Console.ReadLine();
        }
    }
}