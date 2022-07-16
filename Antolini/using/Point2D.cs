namespace DefaultNamespace
{
    public class Point2D
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2D Multiplication(double mul) => this;

        public Point2D Sum(Point2D point) => this;

        public Point2D Subtract(Point2D point) => this;

        public double Module(Point2D point) => 0;
    }
}
