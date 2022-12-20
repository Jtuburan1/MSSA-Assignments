using System;

namespace Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, would you like to perform Addition, Subtraction, Multiplication, Division?");
            Console.WriteLine("Maybe you'd like to determine if two numbers are equal to each other, just type 'Equal' in the console.");
            Console.WriteLine("I can also add the numbers from 0 to 10, if you would like me to perform this function please type 'SumOfNumbers'.");
            string function = Console.ReadLine();
            switch (function)
            {
                case "Addition":
                    Addition();
                    break;
                case "Subtraction":
                    Subtraction();
                    break;
                case "Multiplication":
                    Multiplication();
                    break;
                case "Division":
                    Division();
                    break;
                case "Equal":
                    IfEqual();
                    break;
                case "SumOfNumbers":
                    SumOfNumbers();
                    break;
                default:
                    Console.WriteLine("That is not a function we can perform at this time.");
                    break;
            }

        }

        #region Addition
        static void Addition()
        {
            Console.WriteLine("Okay, what TWO numbers would you like to add together? Hit Enter after inputting each number.");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Your total is: " + (numOne + numTwo));
        }
        #endregion

        #region Subtraction
        static void Subtraction()
        {
            Console.WriteLine("Okay, what TWO numbers would you like to subtract? Hit Enter after inputting each number.");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Your total is: " + (numOne - numTwo));
        }
        #endregion

        #region Multiplication
        static void Multiplication()
        {
            Console.WriteLine("Okay, what TWO numbers would you like to multiply together? Hit Enter after inputting each number.");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Your total is: " + (numOne * numTwo));
        }
        #endregion

        #region Division
        static void Division()
        {
            Console.WriteLine("Okay, what TWO numbers would you like to divide? Hit Enter after inputting each number.");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double total = numOne/numTwo;
            Console.WriteLine("Your total is: {0}", total);
        }
        #endregion

        #region IfEqual function
        static void IfEqual()
        {
            Console.WriteLine("Input TWO numbers and I will tell you if they are equal or not.");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            if (numOne == numTwo)
            {
                Console.WriteLine("{0} and {1} are equal", numOne, numTwo);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", numOne, numTwo);
            }
        }
        #endregion

        #region Sum of numbers function
        static void SumOfNumbers()
        {
            int startNumber = 0;
            int total = 0;
            int loopCounter;
            for(loopCounter = 0; startNumber <=10; startNumber++)
            {
                total = total + startNumber;
                Console.WriteLine("The current total of all the numbers is {0} with the loop count at {1}.", total, loopCounter);
                loopCounter++;
            }
        }
        #endregion
    }
}