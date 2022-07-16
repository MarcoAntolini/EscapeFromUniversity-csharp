namespace DefaultNamespace;

public class HitBox : IHitBox, Rectangle {
    
    private readonly Point2D _topLeft;
	private readonly Point2D _bottomRight;

	public HitBox(Point2D topLeft, Point2D bottomRight) {
		super(topLeft, bottomRight);
		_bottomRight = new Point2D(bottomRight);
		_topLeft = new Point2D(topLeft);
	}
}