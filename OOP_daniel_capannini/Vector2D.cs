using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public class Vector2D : Point2D
    {
        public Vector2D(double x, double y) : base(x, y)
        {

        }
        public Vector2D Normal() => this;

        public new Vector2D Multiplication(double mul) => this;
    }
}
