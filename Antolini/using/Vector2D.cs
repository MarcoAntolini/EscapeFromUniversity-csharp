namespace DefaultNamespace;

using System;

public class Vector2D : Point2D
{
    
    public Vector2D(double x, double y) : base(x, y);
    
    public Vector2D(Vector2D vector) : base(vector.X, vector.Y);

    public Vector2D Multiplication(double mul) => new Vector2D(X * mul, Y * mul);

    public Vector2D Normal() {
        double module = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        return new Vector2D(X / module, Y / module);
    }
}