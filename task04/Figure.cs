using System;

namespace task04
{
    public class Figure
    {
        public string Name { get; }
        private Point[] Points { get; set; }

        public Figure(Point point1, Point point2, Point point3)
        {
            Name = point1.Name;
            Points = new[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            Name = point1.Name;
            Points = new[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            Name = point1.Name;
            Points = new[] { point1, point2, point3, point4, point5 };
        }

        private static double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) +
                      Math.Pow(b.Y - a.Y, 2) * 1.0);
        }
        public static void PerimeterCalculator(Figure figure)
        {
            double perimeter = 0;
            if (figure.Points.Length < 2)
            {
                perimeter = 0;
            }
            else
            {
                for (var i = 0; i <= figure.Points.Length - 2; i++)
                {
                    perimeter += LengthSide(figure.Points[i + 1], figure.Points[i]);
                }
                perimeter += LengthSide(figure.Points[^1], figure.Points[0]);
            }
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}
