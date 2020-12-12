using System;

namespace givenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Determining the equation using any two pints");
                Console.WriteLine();
                Console.Write("Your x1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Your y1: ");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("Your x2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Your y2: ");
                double y2 = double.Parse(Console.ReadLine());

                double slope = Slope(x1, y1, x2, y2);
                double intercept = YIntercept(x2, y2, slope);

                Equation(intercept, slope);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Only numbers are accepted");
                Console.ReadKey();
            }
            


        }

        public static double Slope(double x1, double y1, double x2, double y2)
        {
            double ySlope = y2 - y1;
            double xSlope = x2 - x1;
            double fSlope = Math.Round((ySlope / xSlope), 2);
            return fSlope;
        }

        public static double YIntercept(double x2, double y2, double slope)
        {
            double intercept = Math.Round(y2 - (slope * x2), 2);
            return intercept;
        }

        public static void Equation(double intercept, double slope)
        {
            Console.WriteLine($"The linear equation for the given points is f(x) = {slope}x + {intercept}.");
        }
    }
}
