namespace DefaultNamespace;

public class Rectangle {

    private readonly Point2D TopLeft { get; }
    private readonly Point2D BottomRight { get; }

    public Rectangle(Point2D topLeft, Point2D bottomRight)
    {
        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    public double GetMinX() => TopLeft.X;

    public double GetMaxX() => BottomRight.X;

    public double GetMinY() => TopLeft.Y;

    public double GetMaxY() => BottomRight.Y;

    public double GetWidth() => this.GetMaxX() - this.GetMinX();

    public double GetHeight() => this.GetMaxY() - this.GetMinY();

    public Point2D GetTopRight() => new Point2D(BottomRight.X, TopLeft.Y);

    public Point2D GetBottomLeft() => new Point2D(TopLeft.X, BottomRight.Y);
}