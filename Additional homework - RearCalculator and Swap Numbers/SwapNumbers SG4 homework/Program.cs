using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers_SG4_homework
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {

            /* Task no.3 - Create new console application “SwapNumbers”. 
            Input 2 numbers from the console and then swap the values of 
            the variables so that the first variable has the second value 
            and the second variable the first value.
            Please find example below:

            Test Data:
            Input the First Number: 5
            Input the Second Number: 8
 
            Expected Output:
            After Swapping:
            First Number: 8 
            Second Number: 5 */


            Console.WriteLine("Input the first number:");
            string numb1 = Console.ReadLine();
            int numby1 = int.Parse(numb1);
            Console.WriteLine($"Before the swap the first number is equal to {numby1}");

            Console.WriteLine("Input the second number:");
            string numb2 = Console.ReadLine();
            int numby2 = int.Parse(numb2);
            Console.WriteLine($"Before the swap the first number is equal to {numby2}");

            numby1 = numby1 + numby2;
            numby2 = numby1 - numby2;
            numby1 = numby1 - numby2;

            Console.WriteLine($"After the swap the first number is equal to {numby1}");
            Console.WriteLine($"After the swap the second number is equal to {numby2}");


            Console.Read();

        }
    }
}
