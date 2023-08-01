using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());

                double area = Math.PI * radius * radius;
                double circumference = 2 * Math.PI * radius;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Circumference: " + circumference);
            }
        }
    }


}
    }
}
