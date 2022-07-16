namespace DefaultNamespace;

public interface IBulletFactory {

    IBullet CreatePlayerBullet(Point2D startPosition, Vector2D direction, int damage, GameInit map);

    IBullet CreateBoss1Bullet(Point2D startPosition, Vector2D direction, GameInit map);

    IBullet CreateBoss2Bullet(Point2D startPosition, Vector2D direction, GameInit map);

    IBullet CreateBoss3Bullet(Point2D startPosition, Vector2D direction, GameInit map);

    IBullet CreateBoss4Bullet(Point2D startPosition, Vector2D direction, GameInit map);

    IBullet CreateBoss5Bullet(Point2D startPosition, Vector2D direction, GameInit map);

    IBullet CreateBoss6Bullet(Point2D startPosition, Vector2D direction, GameInit map);
}