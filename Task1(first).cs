using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Please choose operation:(+,-,*,/);");

            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine("The answer is " + (number1 + number2));
            }

            else if (operation == "-")
            {
                Console.WriteLine("The answer is" + (number1 - number2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("The answe is" + (number1 * number2));
            }
            else if (operation == "/")
            {
                Console.WriteLine("The answe is" + (number2 / number1));

            }
        }
    }
}

        

    

