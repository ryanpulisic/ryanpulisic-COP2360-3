using System;

namespace DivisionAndConversionExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            try
            {
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                int result = Divide(number1, number2);

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid whole numbers only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number entered is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
