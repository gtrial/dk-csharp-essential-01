namespace task02
{
    public class Rectangle
    {
        public Rectangle(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        private int Side1 { get; set; }
        private int Side2 { get; set; }

        public double Area => AreaCalculator(this);
        public double Perimeter => PerimeterCalculator(this);

        private static double AreaCalculator(Rectangle rectangle)
        {
            return rectangle.Side1 * rectangle.Side2;
        }
        private static double PerimeterCalculator(Rectangle rectangle)
        {
            return (rectangle.Side1 + rectangle.Side2) * 2;
        }
    }
}
