using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            do
            {
                Console.WriteLine("Please input a number between 1-10");
                int num = int.Parse(Console.ReadLine());

                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("The factorial of {0} is {1}", num, factorial);
                Console.ReadKey();


                Console.WriteLine("Continue? Y/N)");
                input = Console.ReadLine();

            }
            while (input == "y");
        }
    }
}