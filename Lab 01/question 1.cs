using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        {
using System;

namespace NameAndBatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt the user to enter their batch
            Console.Write("Enter your batch: ");
            string batch = Console.ReadLine();

            // Print the name and batch to the console
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Batch: " + batch);

            // Wait for user input to exit the application
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

        }
    }
}
