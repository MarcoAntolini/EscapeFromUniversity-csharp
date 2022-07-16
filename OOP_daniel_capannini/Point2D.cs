using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public class Point2D
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = X;
            Y = Y;
        }

        public Point2D Multiplication(double mul) => this;

        public Point2D Sum(Point2D point) => this;

        public Point2D Subtract(Point2D point) => this;

        public double Module(Point2D point) => 0;
    }
}
