using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.Write("Enter a positive integer: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                Console.WriteLine("Sum of odd numbers from 1 to " + n + ": " + sum);
            }
        }
    }

}
    }
}
