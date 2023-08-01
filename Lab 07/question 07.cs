using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        {
             void Main()
            {
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];
                int[] resultArray = new int[size];

                // Input values for array1
                Console.WriteLine("Enter values for array1:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i}: ");
                    array1[i] = int.Parse(Console.ReadLine());
                }

                // Input values for array2
                Console.WriteLine("Enter values for array2:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i}: ");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                // Scalar Sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i];
                }
                Console.WriteLine("Scalar Sum: " + scalarSum);

                // Vector Sum
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = array1[i] + array2[i];
                }
                Console.WriteLine("Vector Sum: " + string.Join(", ", resultArray));

                // Vector Product
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = array1[i] * array2[i];
                }
                Console.WriteLine("Vector Product: " + string.Join(", ", resultArray));

                // Scalar Product
                int scalarProduct = 1;
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = array1[i] * array2[i];
                    scalarProduct *= resultArray[i];
                }
                Console.WriteLine("Scalar Product: " + scalarProduct);
            }
        }

    }
}
}
