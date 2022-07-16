namespace DefaultNamespace;

public enum GameObjectTypeEnum {

    PLAYER = GameCollisionType.ENTITY,
    BOSS1 = GameCollisionType.ENTITY,
    BOSS2 = GameCollisionType.ENTITY,
    BOSS3 = GameCollisionType.ENTITY,
    BOSS4 = GameCollisionType.ENTITY,
    BOSS5 = GameCollisionType.ENTITY,
    BOSS6 = GameCollisionType.ENTITY,
    WALL = GameCollisionType.OBSTACLE,
    DOOR = GameCollisionType.NADA,
    FURNITURE = GameCollisionType.OBSTACLE,
    NPC = GameCollisionType.OBSTACLE,
    SHOP = GameCollisionType.OBSTACLE,
    BULLET_PLAYER = GameCollisionType.BULLET,
    BULLET_BOSS1 = GameCollisionType.IMMUNE_BULLET,
    BULLET_BOSS2 = GameCollisionType.BULLET,
    BULLET_BOSS3 = GameCollisionType.BULLET,
    BULLET_BOSS4 = GameCollisionType.IMMUNE_BULLET,
    BULLET_BOSS5 = GameCollisionType.BULLET,
    BULLET_BOSS6 = GameCollisionType.IMMUNE_BULLET,

}