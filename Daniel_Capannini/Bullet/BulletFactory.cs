using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    public interface BulletFactory
    {
        Bullet createPlayerBullet(Point2D startPosition, Vector2D direction, int damage, GameInit map);
        Bullet createBoss1Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet createBoss2Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet createBoss3Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet createBoss4Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet createBoss5Bullet(Point2D startPosition, Vector2D direction, GameInit map);
        Bullet createBoss6Bullet(Point2D startPosition, Vector2D direction, GameInit map);
    }
}
