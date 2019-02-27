using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_homework___RearCalculator_SG4
{
    class RearCalculator
    {
        static void Main(string[] args)
        {

            /* Task no.1 - Create new console application “RealCalculator” that 
            takes two numbers from the input and asks what operation would the user 
            want to be done ( +, - , * , / ). Then it returns the result. If the user
            enters a wrong operation display "Invalid operation" and terminate the program.
            
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +
 
            Expected Output:
            The result is: 25 */

            Console.WriteLine("Please enter your desired arithmetic operation:");
            string ope = Console.ReadLine();

            if (ope != "+" && ope != "-" && ope != "*" && ope != "/")
            {
                Console.WriteLine("Invalid operation selected!!!");
                System.Environment.Exit(1);


            }

            Console.WriteLine("Enter the First number:");
            string numberOne = Console.ReadLine();
            int num1 = int.Parse(numberOne);

            Console.WriteLine("Enter the second number:");
            string numberTwo = Console.ReadLine();
            int num2 = int.Parse(numberTwo);

            if (ope == "+")
            {
                Console.WriteLine($"The result is: {num1 + num2}");
            }
            else if (ope == "-")
            {
                Console.WriteLine($"The result is: {num1 - num2}");
            }
            else if (ope == "*")
            {
                Console.WriteLine($"The result is: {num1 * num2}");
            }
            else if (ope == "/")
            {
                Console.WriteLine($"The result is: {num1 / num2}");
            }

            Console.Read();

        }
    }
}
