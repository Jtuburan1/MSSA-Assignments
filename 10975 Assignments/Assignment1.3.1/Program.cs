using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a program that will calculate the area of a circle for you.");
            AreaOfCircle();
        }

        #region Area of Triangle function
        static void AreaOfCircle()
        {
            try
            {
                const double pi = 3.14159265359;
                Console.WriteLine("Please input the radius of the circle.");
                double length = Convert.ToDouble(Console.ReadLine());
                double area = (length * 2) * pi;
                Console.WriteLine("Your total area is: {0}", area);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion
    }
}