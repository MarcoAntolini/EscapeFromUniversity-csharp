namespace DefaultNamespace;

public class BulletFactory : IBulletFactory {

    public override IBullet CreatePlayerBullet(Point2D startPosition, Vector2D direction, int damage, GameInit map) => null;

    public override IBullet CreateBoss1Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;

    public override IBullet CreateBoss2Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;

    public override IBullet CreateBoss3Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;

    public override IBullet CreateBoss4Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;

    public override IBullet CreateBoss5Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;

    public override IBullet CreateBoss6Bullet(Point2D startPosition, Vector2D direction, GameInit map) => null;
}