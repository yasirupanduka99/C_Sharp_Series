namespace C_Sharp_Operators { 
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------- C# Operators ---------\n");
            
            double number1 = 10;
            double number2 = 20;
            double number3 = 20;

            //Thera are four types of Operators in programming  ----> 1.Arithmatic Opertaors  2.Asign Operators  3.Comparition Operators  4.Logical Operators

            // ------ 1.Arithmatic Operators ------
            Console.WriteLine("\n--------- 1.Arithmatic Operators ---------\n");

            Console.WriteLine("Addition of numbers                          : " + (number1 + number2)); //Addition Operator
            Console.WriteLine("Subtraction of numbers                       : " + (number1 - number2)); //Subtraction Operator
            Console.WriteLine("Division of numbers                          : " + (number1 / number2)); //Division Operator
            Console.WriteLine("Multiplication of numbers                    : " + (number1 * number2)); //Multiplication Operator
            Console.WriteLine("Reminder of numbers                          : " + (number1 % number2)); //Reminder/Modulo Operator
            Console.WriteLine("Increment of number1                         : " + (number1++)); //Increment Operator
            Console.WriteLine("Decrement of number1                         : " + (number1--)); //Decrement Operator

            // ------ 2.Asign Operator ------
            Console.WriteLine("\n\n--------- 2.Asign Operator ---------\n");

            String name = "Kawaki"; //This = is the asign operator
            Console.WriteLine("Name is                                      : " + name); //Equal Operator

            // ------ 3.Comparition Operators ------
            Console.WriteLine("\n\n--------- 3.Comparition Operators ---------\n");

            Console.WriteLine("Number1 & Number2 are equal?                 : " + (number1 == number2)); //Equal Operator
            Console.WriteLine("Number2 & Number3 are equal?                 : " + (number2 == number3)); //Equal Operator
            Console.WriteLine("Number1 & Number2 are not equal?             : " + (number1 != number2)); //Not Equal Operator
            Console.WriteLine("Number2 & Number3 are not equal?             : " + (number2 != number3)); //Not Equal Operator
            Console.WriteLine("Is Number1 greater than Number2?             : " + (number1 > number2)); //Greater Than Operator
            Console.WriteLine("Is Number1 less than Number2?                : " + (number1 < number2)); //Less Than Operator
            Console.WriteLine("Is Number1 greater than or equal to Number2? : " + (number1 >= number2)); //Greater or Equal to Operator
            Console.WriteLine("Is Number1 less than or equal to Number2?    : " + (number1 <= number2)); //Less or Equal to Operator

            // ------ 4.Logical Operators ------
            Console.WriteLine("\n\n--------- 4.Logical Operators ---------\n");

            Console.WriteLine("AND (&&) Operator                            : " + (number1 > number2 && number2 == number3)); //AND Operator - && - if one of the condition false full statement go false. 
            Console.WriteLine("OR (||) Operator                             : " + (number1 > number2 || number2 == number3)); //OR Operator - || - if one of the condition true full statement go true.
            Console.WriteLine("NOT (!) Operator                             : " + (!(number2 == number3))); //NOT Operator - ! - give the oposite of equation.


            Console.ReadLine();
        }
    }

}