using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    public interface BulletFactory
    {
        Bullet CreatePlayerBullet(Point2D startPosition, Vector2D direction, int damage, GameInit map);
        Bullet CreateBoss1Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet CreateBoss2Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet CreateBoss3Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet CreateBoss4Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet CreateBoss5Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet CreateBoss6Bullet(Point2D startPosition, Vector2D direction, GameInit map);
    }
}
