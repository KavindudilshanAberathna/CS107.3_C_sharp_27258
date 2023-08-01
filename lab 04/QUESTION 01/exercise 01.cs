using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertValues
        {
            public void kilometerTOmeter()
            {
                Console.Write("Enter the distance in kilometers: ");
                double km = double.Parse(Console.ReadLine());
                double meters = km * 1000;
                Console.WriteLine($"{km} kilometers is equal to {meters} meters.");
            }
        }

        class Program
        {
            static void Main()
            {
                ConvertValues converter = new ConvertValues();
                converter.kilometerTOmeter();
            }
        }

    }
}
}
