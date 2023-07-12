using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example using TryParse method to convert string to int
            Console.WriteLine("enter a number");
            string num = Console.ReadLine();
            Console.WriteLine($"{num} is a type of " + num.GetType());
            if (int.TryParse(num, out int result))
            {
                Console.WriteLine("conversion is successful");
                Console.WriteLine("parsed string to integer is : \t" + result);
                Console.WriteLine($"{result} is a type of " + result.GetType());
            }
            else
            {
                Console.WriteLine("failed to parse");
            }
            Console.ReadKey();


            // Example using Convert method to convert string to double
            Console.WriteLine("Enter a number");
            string doubleString =Console.ReadLine();
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }


            // Example using Parse method to convert string to decimal
            Console.WriteLine("enter a number");
            string decimalString = Console.ReadLine();
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");
            }
            Console.ReadKey();

        }
    }
}
