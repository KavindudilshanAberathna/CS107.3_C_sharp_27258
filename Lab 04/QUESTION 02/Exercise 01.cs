using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleCalculator
    {
        // Separate class to find values of a circle
        class FindValues
        {
            public double FindArea(double radius)
            {
                return Math.PI * radius * radius;
            }

            public double FindCircumference(double radius)
            {
                return 2 * Math.PI * radius;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Circle Calculator");
                Console.Write("Enter the radius of the circle: ");

                if (double.TryParse(Console.ReadLine(), out double radius))
                {
                    FindValues circleValues = new FindValues();

                    double area = circleValues.FindArea(radius);
                    double circumference = circleValues.FindCircumference(radius);

                    Console.WriteLine($"Area of the circle: {area:F2}");
                    Console.WriteLine($"Circumference of the circle: {circumference:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric value for the radius.");
                }
            }
        }
    }

}
    }
}
