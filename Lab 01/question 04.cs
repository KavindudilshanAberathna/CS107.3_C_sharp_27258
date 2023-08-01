using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            {
                Console.WriteLine("Enter the employee's salary:");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the tax rate (%):");
                double taxRate = double.Parse(Console.ReadLine());

                double taxAmount = salary * (taxRate / 100);
                double salaryAfterTax = salary - taxAmount;

                Console.WriteLine("Salary after tax: " + salaryAfterTax);

                Console.ReadKey();
            }
        }
    }

}
    }
}
