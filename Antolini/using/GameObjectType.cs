namespace DefaultNamespace;

public class GameObjectType : GameObjectTypeEnum {

    private GameCollisionType _collisionType;

    GameObjectType(GameCollisionType collisionType) {
        _collisionType = collisionType;
    }

    public override GameCollisionType GetCollisionType() => _collisionType;

    public void SetCollisionType(GameCollisionType collisionType) => _collisionType = collisionType;
}