using System.Security.Cryptography;

namespace Assignment_1._4
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int xVal, int yVal)
            {
                this.x = xVal;
                this.y = yVal;
            }

            public void CompCoord(int pointOne, int pointTwo)
            {
                if (pointOne == pointTwo)
                {
                    Console.WriteLine("Point 1 and Point 2 have the same x coordinate.");

                }
                else if (pointOne > pointTwo)
                {
                    Console.WriteLine("Point 1 is to the right of Point 2");
                }
                else
                {
                    Console.WriteLine("Point 1 is to the left of point 2");
                }
            }
        }
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();

            Student James = new Student(13536945, "James", 'A');
            
            try
            {
                Console.WriteLine("Please input your 'x' value for point 1");
                P1.x = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Please input your 'y' value for point 1");
                P1.y = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                Console.WriteLine("Please input your 'x' value for point 2");
                P2.x = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Please input your 'y' value for point 2");
                P2.y = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                P1.CompCoord(P1.x, P2.x);

                Console.WriteLine();
                Console.WriteLine("Information on Student:");
                Console.WriteLine();

                James.StudentInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}