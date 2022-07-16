namespace DefaultNamespace;

public class Direction : DirectionEnum {

    private Vector2D _direction;

    Direction(Vector2D direction) => _direction = direction;
    
    public Vector2D GetDirection() => _direction;
}