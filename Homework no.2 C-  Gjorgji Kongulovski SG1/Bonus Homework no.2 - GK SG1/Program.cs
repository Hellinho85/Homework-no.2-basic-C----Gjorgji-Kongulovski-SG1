using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Homework_no._2___GK_SG1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current temperature in centigrade:");
            string temp = Console.ReadLine();
            int centTemp = int.Parse(temp);

            if (centTemp < 0)
            {
                Console.WriteLine("Freezing Weather!!!");

            }
            else if (centTemp > 0 && centTemp < 10)
            {
                Console.WriteLine("Very Cold Weather!!!");

            }
            else if (centTemp > 10 && centTemp < 20)
            {
                Console.WriteLine("Cold Weather!!!");

            }
            else if (centTemp > 20 && centTemp < 30)
            {
                Console.WriteLine("Normal in Temp!!!");

            }
            else if (centTemp > 30 && centTemp < 40)
            {
                Console.WriteLine("It's Hot!!!");

            }
            else if (centTemp >= 40)
            {
                Console.WriteLine("It's very Hot!!!");
            }

            Console.Read();

        }
    }
}
