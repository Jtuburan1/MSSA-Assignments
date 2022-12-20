using System;
using System.Linq;

namespace Assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnEvenNumbers();
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
            StringInReverseOrder("qwerty");
            StringInReverseOrder("oe93 kr");
            Console.Write("Please input a string:");
            string input = Console.ReadLine()!;
            NumberOfSpaces(input);
        }

        public static void ReturnEvenNumbers()
        {
            for(int i=1; i<100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        public static bool IfYearIsLeap(int year)
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }

        public static void StringInReverseOrder(string input)
        {
            char[] array = input.ToCharArray();
            for(int bgn = 0, end = input.Length - 1; bgn < end; bgn++, end--)
            {
                array[bgn] = input[end];
                array[end] = input[bgn];
            }
            Console.WriteLine(new string(array));
        }

        public static void NumberOfSpaces(string inputString)
        {
            char[] newString = inputString.ToCharArray();
            int count=0;
            foreach(char c in newString)
            {
                if(char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"'{inputString}' contains {count} spaces.");
        }
    }
}