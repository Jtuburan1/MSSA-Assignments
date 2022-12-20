using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables to store name, age (decimal), and address and print them to the console
            //prompt user for the variables and print them to a console
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            decimal yourAge = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Where do you live?");
            string yourAddress = Console.ReadLine();

            Console.WriteLine();
            Console.Out.WriteLine("Your name is {0}", yourName);
            Console.Out.WriteLine("You're {0} years old", yourAge);
            Console.Out.WriteLine("Your address is {0}", yourAddress);

            //declare basic datatypes like int, float, decimal and double and print their min/max values
            Console.WriteLine();
            Console.Out.WriteLine("The data type of integers ranges from {0} to {1}", int.MinValue, int.MaxValue);
            Console.Out.WriteLine("The data type of float ranges from {0} to {1}", float.MinValue, float.MaxValue);
            Console.Out.WriteLine("The data type of decimal ranges from {0} to {1}", decimal.MinValue, decimal.MaxValue);
            Console.Out.WriteLine("The data type of double ranges from {0} to {1}", double.MinValue, double.MaxValue);
        }
    }
}