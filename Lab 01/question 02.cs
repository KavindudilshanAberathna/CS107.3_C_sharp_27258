using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.WriteLine("Enter the radius of the circle:");
                double radius = double.Parse(Console.ReadLine());

                double area = Math.PI * radius * radius;

                Console.WriteLine("Area of the circle: " + area);

                Console.ReadKey();
            }
        }
    }

}
    }
}
