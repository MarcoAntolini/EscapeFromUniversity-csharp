namespace DefaultNamespace;

public interface IGameObject {

    IHitBox GetObjectHitBox();

    GameObjectType GetType();
}