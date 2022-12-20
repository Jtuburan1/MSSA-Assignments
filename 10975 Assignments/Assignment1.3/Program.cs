using System;
using System.Reflection.Emit;

namespace Assignment1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option below that you would like to calculate the area of and type the corresponding number:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. List Values in Array(Reversed)");
            Console.WriteLine("5. Bubble Sort Array in Ascending Order");
            Console.WriteLine("6. Bubble Sort Array in Descending Order \n");
            string areaOfShape = Console.ReadLine()!;
            Console.WriteLine();

            switch (areaOfShape)
            {
                case "1":
                    Console.WriteLine("Type the length of one side of the square you want the area of.");
                    AreaOfSquare(decimal.Parse(Console.ReadLine()!));
                    break;
                case "2":
                    Console.WriteLine("Type the LENGTH of the base first and then the HEIGHT of the triangle you want the area of. Hit enter after each input.");
                    AreaOfTriangle(decimal.Parse(Console.ReadLine()!), decimal.Parse(Console.ReadLine()!));
                    break;
                case "3":
                    Console.WriteLine("Type the length first and then the width of the rectangle you want the area of. Hit enter after each input.");
                    AreaOfRectangle(decimal.Parse(Console.ReadLine()!), decimal.Parse(Console.ReadLine()!));
                    break;
                case "4":
                    ArrayReverse();
                    break;
                case "5":
                    int[] ascendArray = new int[] {3, 5, 7, 8, 6, 9, 10};
                    BubbleSortAscend(ascendArray);
                    break;
                case "6":
                    int[] descendArray = new int[] { 3000, 45, 69, 77, 1, 4, 10 };
                    BubbleSortDescend(descendArray);
                    break;
                default:
                    Console.WriteLine("That is not a function we can perform yet.");
                    break;
            }
        }

        #region Area of Square function
        static void AreaOfSquare(decimal length)
        {
            decimal area = length * length;
            Console.WriteLine("Your total area is: {0}", area);
        }
        #endregion

        #region Area of Triangle function
        static void AreaOfTriangle(decimal length, decimal height)
        {
            decimal area = (length / 2) * height;
            Console.WriteLine("Your total area is: {0}", area);
        }
        #endregion

        #region Area of Rectangle function
        static void AreaOfRectangle(decimal length, decimal width)
        {
            decimal area = length * width;
            Console.WriteLine("Your total area is: {0}", area);
        }
        #endregion

        #region Reading array in reverse order
        static void ArrayReverse()
        {
            int[] myArray = new int[3];
            int start;
            int numOne;
            int numTwo;
            int numThree;

            Console.WriteLine("Insert element - 0: ");
            numOne = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insert element - 1: ");
            numTwo = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insert element - 2: ");
            numThree = int.Parse(Console.ReadLine()!);

            myArray[0] = numOne;
            myArray[1] = numTwo;
            myArray[2] = numThree;

            Console.WriteLine("These are your inputs reversed.");

            for (start = 2; start >= 0; start--)
            {
                Console.WriteLine(myArray[start]);
            }

        }
        #endregion

        #region Bubble Sort Ascending
        static void BubbleSortAscend(int[] array)
        {
            Console.WriteLine("These are the values in this array: ");
            foreach(int num in array)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("These are the numbers sorted in ascending order: ");
            int temp;
            for(int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length -1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
        #endregion

        #region Bubble Sort Descend
        static void BubbleSortDescend(int[] array)
        {
            Console.WriteLine("These are your current values in this array: ");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("These are the same values in descending order: ");
            int temp;
            for(int firstNum = 0; firstNum < array.Length - 1; firstNum++)
            {
                for(int secondNum = 0; secondNum < array.Length - 1 - firstNum; secondNum++)
                {
                    if (array[secondNum] < array[secondNum + 1])
                    {
                        temp = array[secondNum];
                        array[secondNum] = array[secondNum + 1];
                        array[secondNum + 1] = temp;
                    }
                }
            }
            foreach(int num in array)
            {
                Console.WriteLine(num);
            }
        }
        #endregion
    }
}