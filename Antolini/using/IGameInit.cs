namespace DefaultNamespace;

public interface IGameInit {

    void AddDynamicGameObject(DynamicGameObject dGObj);

    IMapManager GetMapManager();

}