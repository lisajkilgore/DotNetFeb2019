using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello World";
            Console.WriteLine("Hello World");
            Console.ReadKey();

            string hello = "Hello World";
            Console.WriteLine(hello);
            Console.ReadLine();

            string firstName = "Lisa";
            string lastName = "Kilgore";

            Console.WriteLine($"Good morning, {firstName} {lastName}");
            Console.ReadLine();

            Console.WriteLine("Please enter your first name.");
            string firstNameTwo = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastNameTwo = Console.ReadLine();

            Console.WriteLine("Hello" + firstNameTwo + lastNameTwo);
        }
    }
}
