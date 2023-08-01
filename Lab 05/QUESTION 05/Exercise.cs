using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            import java.util.Scanner;

class ArrayUtils
        {
            public static int findMinimum(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            }

            public static int findMaximum(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }

            public static double findAverage(int[] arr)
            {
                int sum = 0;
                for (int num : arr)
                {
                    sum += num;
                }
                return (double)sum / arr.length;
            }

            public static void reverseArray(int[] arr)
            {
                int left = 0;
                int right = arr.length - 1;
                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }

        public class Main
        {
            public static void main(String[] args)
            {
                int[] array = new int[10];
                Scanner scanner = new Scanner(System.in);

                System.out.println("Enter 10 elements:");
                for (int i = 0; i < 10; i++)
                {
                    array[i] = scanner.nextInt();
                }

                int minimum = ArrayUtils.findMinimum(array);
                int maximum = ArrayUtils.findMaximum(array);
                double average = ArrayUtils.findAverage(array);

                System.out.println("Minimum value: " + minimum);
                System.out.println("Maximum value: " + maximum);
                System.out.println("Average value: " + average);

                ArrayUtils.reverseArray(array);
                System.out.println("Array in reverse order:");
                for (int num : array)
                {
                    System.out.print(num + " ");
                }
            }
        }

    }
}
}
