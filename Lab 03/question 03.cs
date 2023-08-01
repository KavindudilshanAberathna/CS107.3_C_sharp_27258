using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int sum = 0;
                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }

                Console.WriteLine("Sum of digits: " + sum);
            }
        }
    }

}
    }
}
