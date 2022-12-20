namespace Assignment2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle calculateCircle = new Circle();
            Square calculateSquare = new Square();

            Console.WriteLine("Please input the radius of the circle you want the area of:");
            calculateCircle.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your circle is: {calculateCircle.CalculateArea()}\n");

            Console.WriteLine("Please input the length of one side of the square you want the area of:");
            calculateSquare.Sideofsquare = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your square is: {calculateSquare.CalculateArea()}\n");
        }
    }
}