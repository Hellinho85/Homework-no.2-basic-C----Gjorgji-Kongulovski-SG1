using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_no._2_C___Gjorgji_Kongulovski_SG1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Task no.1 - In the main method ask the user to enter -
            "What is behind door number: 1, 2, 3”*/


            Console.WriteLine("What is behind door number: 1, 2, 3?");
            string number = Console.ReadLine();
            int lotterySwitch = int.Parse(number);

            switch (lotterySwitch)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Nothing for you today my friend!");
                    break;                    
            }


            /* Task no.2 - In the main method tell the user to enter four numbers 
            as input to calculate and print the average.*/


            Console.WriteLine("Please enter four numbers as input and find out your average!");

            Console.WriteLine("Enter the First number:");
            string numberOne = Console.ReadLine();
            int num1 = int.Parse(numberOne);

            Console.WriteLine("Enter the second number:");
            string numberTwo = Console.ReadLine();
            int num2 = int.Parse(numberTwo);

            Console.WriteLine("Enter the third number:");
            string numberThree = Console.ReadLine();
            int num3 = int.Parse(numberThree);

            Console.WriteLine("Enter the fourth number:");
            string numberFour = Console.ReadLine();
            int num4 = int.Parse(numberFour);

            Console.WriteLine((num1 + num2 + num3 + num4) / 4);


            Console.Read();
        }
    }
}
