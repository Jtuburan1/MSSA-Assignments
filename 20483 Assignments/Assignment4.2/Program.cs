using System.Collections;
using System.Collections.Generic;

namespace Assignment4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Please choose an option below:\n1.Store integers in 2D Array.\n2.Add 2 matrices of the same size.\n3.Add 2-3 numbers.\n4.Multiply 2-3 numbers.\n5.Overload for area of 2 Circles.");
            int choice = int.Parse(Console.ReadLine()!);
            switch(choice)
            {
                case 1:
                    StoreIntegersArray();
                    break;
                case 2:
                    Console.WriteLine("Input the size of the square matrix(less than 5):");
                    int sizeOfMatrix = int.Parse(Console.ReadLine()!);
                    AddMatrices(sizeOfMatrix);
                    break;
                case 3:
                    Console.Write("How many numbers would you like to add?(2 or 3):");
                    int amnt = int.Parse(Console.ReadLine()!);
                    switch(amnt)
                    {
                        case 2:
                            Console.Write("Input your first number:");
                            int a = int.Parse(Console.ReadLine()!);
                            Console.Write("Input your second number:");
                            int b = int.Parse(Console.ReadLine()!);
                            OverloadAdd(a, b);
                            break;
                        case 3:
                            Console.Write("Input your first number:");
                            int c = int.Parse(Console.ReadLine()!);
                            Console.Write("Input your second number:");
                            int d = int.Parse(Console.ReadLine()!);
                            Console.Write("Input your third number:");
                            int e = int.Parse(Console.ReadLine()!);
                            OverloadAdd(c, d, e);
                            break;
                        default:
                            Console.WriteLine("That is not a viable option.");
                            Menu();
                            break;
                    }
                    break;
                case 4:
                    Console.Write("How many numbers would you like to multiply?(2 or 3):");
                    int amount = int.Parse(Console.ReadLine()!);
                    switch (amount)
                    {
                        case 2:
                            Console.Write("Input your first number:");
                            float a = float.Parse(Console.ReadLine()!);
                            Console.Write("Input your second number:");
                            float b = float.Parse(Console.ReadLine()!);
                            OverloadMultiply(a, b);
                            break;
                        case 3:
                            Console.Write("Input your first number:");
                            float c = float.Parse(Console.ReadLine()!);
                            Console.Write("Input your second number:");
                            float d = float.Parse(Console.ReadLine()!);
                            Console.Write("Input your third number:");
                            float e = float.Parse(Console.ReadLine()!);
                            OverloadMultiply(c, d, e);
                            break;
                        default:
                            Console.WriteLine("That is not a viable option.");
                            Menu();
                            break;
                    }
                    break;
                case 5:
                    Console.Write("What is the radius of the first circle: ");
                    double rOne = double.Parse(Console.ReadLine()!);
                    TwoCircle firstCircle = new TwoCircle(rOne);
                    Console.Write("What is the radius of the second circle: ");
                    double rTwo = double.Parse(Console.ReadLine()!);
                    TwoCircle secondCircle = new TwoCircle(rTwo);
                    TwoCircle sumOfCircle = firstCircle + secondCircle;
                    Console.WriteLine($"The sum of the circles is {sumOfCircle.SumArea}");
                    TwoCircle diffOfCircle = firstCircle - secondCircle;
                    Console.WriteLine($"The difference of the circles is {diffOfCircle.DiffArea}");

                    break;
            }
        }

        private static void OverloadAdd(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static void OverloadAdd(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        private static void OverloadMultiply(float a, float b)
        {
            Console.WriteLine(a * b);
        }
        private static void OverloadMultiply(float a, float b, float c)
        {
            Console.WriteLine(a * b * c);
        }

        private static void AddMatrices(int sizeOfMatrix)
        {
            int[,] firstMatrix = new int[sizeOfMatrix, sizeOfMatrix];
            int[,] secondMatrix = new int[sizeOfMatrix, sizeOfMatrix];
            int[,] combinedMatrix = new int[sizeOfMatrix, sizeOfMatrix];
            //gather inputs of second matrix
            Console.WriteLine("Input elements of the first matrix");
            for(int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                for(int colmn = 0; colmn < firstMatrix.GetLength(1); colmn++)
                {
                    Console.Write($"element - [{row}],[{colmn}]:");
                    firstMatrix[row, colmn] = int.Parse(Console.ReadLine()!);
                }
            }
            //gather inputs of second matrix
            Console.WriteLine("Input elements of the second matrix");
            for(int row = 0; row < secondMatrix.GetLength(0); row++)
            {
                for(int colmn = 0; colmn < secondMatrix.GetLength(1); colmn++)
                {
                    Console.Write($"element - [{row}],[{colmn}]:");
                    secondMatrix[row, colmn] = int.Parse(Console.ReadLine()!);
                }
            }
            //print first matrix
            Console.WriteLine("The First Matrix is:");
            for(int rows = 0; rows < firstMatrix.GetLength(0); rows++)
            {
                for(int cols = 0; cols < firstMatrix.GetLength(1); cols++)
                {
                    Console.Write(string.Format("{0} ", firstMatrix[rows, cols]));
                }
                Console.Write(Environment.NewLine);
            }
            //print second matrix
            Console.WriteLine("The Second Matrix is:");
            for(int rows = 0; rows < secondMatrix.GetLength(0); rows++)
            {
                for(int cols = 0; cols < secondMatrix.GetLength(1); cols++)
                {
                    Console.Write(string.Format("{0} ", secondMatrix[rows, cols]));
                }
                Console.Write(Environment.NewLine);
            }
            //add two matrices together
            Console.WriteLine("The Addition of the two matrix is:");
            for (int rows = 0; rows < firstMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < firstMatrix.GetLength(1); cols++)
                {
                    combinedMatrix[rows, cols] = firstMatrix[rows, cols] + secondMatrix[rows, cols];
                    Console.Write($"{combinedMatrix[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }

        private static void StoreIntegersArray()
        {
            int[,] twoDimensionArray = new int[2,3];
            for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionArray.GetLength(1); j++)
                {
                    Console.WriteLine("Input a number:");
                    twoDimensionArray[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            for(int rows = 0; rows < twoDimensionArray.GetLength(0); rows++)
            {
                for(int cols = 0; cols < twoDimensionArray.GetLength(1); cols++)
                {
                    Console.Write($"{twoDimensionArray[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
    struct TwoCircle
    {
        double radius;
        double areaSum;
        double areaDiff;

        public TwoCircle(double rOne)
        {
            this.radius = rOne;
        }

        public double SumArea
        {
            get { return areaSum; }
            set { areaSum = value; }
        }

        public double DiffArea
        {
            get { return areaDiff; }
            set { areaDiff = value; }
        }

        public static TwoCircle operator +(TwoCircle firstCircle, TwoCircle secondCircle)
        {
            TwoCircle sumOfCircle = new TwoCircle();
            const double pi = 3.1415;
            double firstCircleArea = firstCircle.radius * firstCircle.radius * pi;
            double secondCircleArea = secondCircle.radius * secondCircle.radius * pi;
            sumOfCircle.areaSum = firstCircleArea + secondCircleArea;
            return sumOfCircle;
        }
        public static TwoCircle operator -(TwoCircle firstCircle, TwoCircle secondCircle)
        {
            TwoCircle diffOfCircle = new TwoCircle();
            const double pi = 3.1415;
            double firstCircleArea = firstCircle.radius * firstCircle.radius * pi;
            double secondCircleArea = secondCircle.radius * secondCircle.radius * pi;
            diffOfCircle.areaDiff = firstCircleArea - secondCircleArea;
            return diffOfCircle;
        }
    }
}