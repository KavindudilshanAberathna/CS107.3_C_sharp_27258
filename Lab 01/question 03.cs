using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            {
                Console.WriteLine("Enter the first number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = double.Parse(Console.ReadLine());

                double sum = num1 + num2;

                Console.WriteLine("Sum: " + sum);

                Console.ReadKey();
            }
        }
    }

}
    }
}
