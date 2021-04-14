using System;

namespace task02
{
    internal static class Program
    {
        static void Main()
        {

            Console.WriteLine("Side 1:");
            var side1 = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Side 2:");
            var side2 = int.Parse(Console.ReadLine() ?? string.Empty);

            Rectangle rectangle = new(side1, side2);

            Console.WriteLine($"Perimeter: {rectangle.Perimeter}\nArea: {rectangle.Area}");
        }
    }
}
