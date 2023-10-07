namespace C_sharp_casting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n------------ C# Casting | Converting DataTypes ------------\n\n");

            //casting means convert one data type to another data type.
            //there are two types of casting ---> 1.implicit casting (Automaticaly casting)  2. Explicit casting (Manual casting)


            // ----- 1.implicit casting | automatic casting ----
            int number; //variable declaration
            number = 10; //variable initilition

            int number2 = 20; //this is variable declaration and initialization

            double numberConvertToDouble = number2; //this is automatic casting / implicit casting. you can cast int to double automatically because that both can contain numbers.

            Console.WriteLine("This is integer no : " + number2);
            Console.WriteLine("This is converted no of integer to double : " + numberConvertToDouble);



            // ---- 2.explicit casting | manual casting ----
            double number3 = 10.5;

            int numberConvertedToInt = (int)number3; //cast to integer
            string numberConvertedToString = number3.ToString(); //cast to string

            Console.WriteLine("\nThis is integer no : " + number3); //this '\n' can cut down a line
            Console.WriteLine("This is converted no of double to integer : " + numberConvertedToInt);
            Console.WriteLine("This converted no of double to string : " + numberConvertedToString);


            Console.ReadLine();
        }
    }
}