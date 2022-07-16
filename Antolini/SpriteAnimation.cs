namespace DefaultNamespace;

public class SpriteAnimation
{

    private Rectangle _position;
    public bool Visible { get; set; }
    public readonly HitBox HitBox { get; }
    public readonly Sprite Sprite { get; }
    
    public SpriteAnimation(Sprite sprite, HitBox hitBox) {
        Sprite = sprite;
        HitBox = hitBox;
    }

    public Rectangle GetPosition() {
        return _position;
    }

    public void SetPosition(Point2D position) {
        Point2D size = position.Sum(new Point2D(50, 57));
        _position = new Rectangle(position, size);
    }

}