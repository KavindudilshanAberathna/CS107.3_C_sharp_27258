using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Enter number " + i + ": ");
                    int number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }
            }
        }
    }

}
    }
}
