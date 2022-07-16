using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    public class BulletFactoryImpl : BulletFactory
    {
        private static double _playerBulletSpeed;
        private static double _bossBulletSpeed;
        private static int _bossBulletDamage;

        public Bullet CreatePlayerBullet(Point2D startPosition, Vector2D direction, int damage, GameInit map) => new BulletImpl(GameObjteType.BULLET_PLAYER, startPosition, _playerBulletSpeed, direction, damage, map);
        public Bullet CreateBoss1Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_1, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);
        public Bullet CreateBoss2Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_2, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);
        public Bullet CreateBoss3Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_3, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);
        public Bullet CreateBoss4Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_4, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);
        public Bullet CreateBoss5Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_5, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);
        public Bullet CreateBoss6Bullet(Point2D startPosition, Vector2D direction, GameInit map) => new BulletImpl(GameObjteType.BULLET_BOSS_6, startPosition, _bossBulletSpeed, direction, _bossBulletDamage, map);

    }
}
