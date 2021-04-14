using System;

namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            Figure figure1 = new(new Point(1, 1, "triangle"), new Point(2, 2, ""), new Point(3, 3, ""));
            Figure figure2 = new(new Point(1, 1, "rectangle"), new Point(2, 2, ""), new Point(3, 3, ""), new Point(4, 4, ""));
            Figure figure3 = new(new Point(1, 1, "pentagon"), new Point(2, 2, ""), new Point(3, 3, ""), new Point(4, 4, ""), new Point(5, 5, ""));

            Console.WriteLine(figure1.Name);
            Figure.PerimeterCalculator(figure1);
            Console.WriteLine(figure2.Name);
            Figure.PerimeterCalculator(figure2);
            Console.WriteLine(figure3.Name);
            Figure.PerimeterCalculator(figure3);
        }
    }
}
