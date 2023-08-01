using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double sum = num1 + num2;
                double subtraction = num1 - num2;
                double multiplication = num1 * num2;
                double division = num1 / num2;

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Subtraction: " + subtraction);
                Console.WriteLine("Multiplication: " + multiplication);
                Console.WriteLine("Division: " + division);
            }
        }
    }


}
    }
}
