using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine().ToLower();

                int vowelCount = 0;
                foreach (char ch in input)
                {
                    if ("aeiou".Contains(ch))
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine("Number of vowels: " + vowelCount);
            }
        }
    }

}
    }
}
