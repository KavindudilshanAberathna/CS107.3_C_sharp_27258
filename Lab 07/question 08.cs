using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Animal
        {
            public void Display()
            {
                Console.WriteLine("I am an Animal.");
            }
        }

        class Dog : Animal
        {
            public void DisplayDog()
            {
                Console.WriteLine("I have four legs.");
            }
        }

        class Program
        {
            static void Main()
            {
                Animal animal = new Animal();
                Dog dog = new Dog();

                animal.Display();
                dog.DisplayDog();
            }
        }

    


