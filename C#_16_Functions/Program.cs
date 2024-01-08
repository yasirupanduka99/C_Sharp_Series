namespace C_Sharp_Functions
{
    class Program
    {

        int sample_variable; //this is global variable. global variable can access any function/method that create inside the this class.

        static void Main(string[] args)
        {
            Console.WriteLine("\n ------------ Functional Programming | Functions ------------ \n\n");

            double number1 = 21; //this is local variable. local environment is this Main method. only inside this main method things can access this local variable.
            double number2 = 10;

            Addition(number1, number2);

            double sub = Substract(number1, number2);
            Console.WriteLine("Substract of no1 - no2 is: " + sub);

            double reminder = 0;
            double divide = Divide(number1, number2, ref reminder); //using this ref you can get multi returning in function
            Console.WriteLine("Divide of no1/no2 is : " + divide);
            Console.WriteLine("Reminder of no1/no2 is : " +  reminder);

            Console.ReadLine();
        }

        //---creating Addition Function as void
        static void Addition(double n1, double n2) //void function doesn't need to return anything
        {
            double addition = n1 + n2;
            Console.WriteLine("Addition of no1 + no2 is : " + addition);
        }

        //---Creating Substract Function as double
        static double Substract(double x1, double x2) //here this function is double type so you have to return double value at the end
        {
            double total = x1 - x2;
            return total;
        }

        static double Divide(double y1, double y2, ref double rem)
        {
            double answer = y1 / y2;
            rem = y1 % y2;
            return answer;
        }
    }
}