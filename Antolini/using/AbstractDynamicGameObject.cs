namespace DefaultNamespace;

public abstract class AbstractDynamicGameObject : IDynamicGameObject {

    private readonly GameObjectType _type;
    private Point2D _position;
    private Vector2D _direction;
    private readonly double _speed;
    private readonly Point2D _hitBoxSize;
    protected IGameInit _map;

    public AbstractDynamicGameObject(GameObjectType type, Point2D position, Point2D hitBoxSize, double speed, Vector2D direction, IGameInit map) {
        _type = type;
        _position = position;
        _speed = speed;
        _direction = direction;
        _map = map;
        _hitBoxSize = hitBoxSize;
    }

    public Point2D GetObjectPosition() => new Point2D(_position);

    public bool CollisionWithCheck(IGameObject gObj2) => this.GetObjectHitBox().IsColliding(gObj2.GetObjectHitBox());

    public override IHitBox GetObjectHitBox() => new HitBox(_position, _position.Sum(_hitBoxSize));

    public override void Move();

    public IGameInit GetMap() => _map;

    public Vector2D GetDirection() => new Vector2D(_direction);
}