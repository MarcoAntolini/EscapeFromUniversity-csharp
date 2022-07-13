using OOP_daniel_capannini.Bullet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    public class BossFactoryImpl : BossFactory
    {
        protected static BulletFactory _bulletCreate = new BulletFactoryImpl();
        private static double _bossSpeed = 100;
        private static Point2D _hitBoxSize = new Point2D(0, 0);
        private static int _bossLife = 100;
        private static double _bossShootDelay = 200;
        private static int _bossDamage = 20;
        private static string _bossExam = "exam_boss";

        private static Vector2D _vector1 = new Vector2D(50, 50);
        private static Vector2D _vector2 = new Vector2D(-50, -50);


        public Boss createBoss1(Point2D position, Vector2D direction, GameInit map) => new Boss1(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS1, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss1 : AbstractBoss
        {
            public Boss1(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot() => this.Map.addDynamicGameObject(_bulletCreate.createBoss1Bullet(this.Position, newDirection(), Map));
        }

        public Boss createBoss2(Point2D position, Vector2D direction, GameInit map) => new Boss2(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS2, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss2 : AbstractBoss
        {
            public Boss2(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot()
            {
                List<Bullet.Bullet> bullets = new List<Bullet.Bullet>();
                bullets.Add(_bulletCreate.createBoss2Bullet(this.Position, newDirection(), Map));
                bullets.Add(_bulletCreate.createBoss2Bullet(this.Position.sum(_vector1), newDirection(), Map));
                bullets.Add(_bulletCreate.createBoss2Bullet(this.Position.sum(_vector2), newDirection(), Map));
                bullets.ForEach(bul => {
                    this.Map.addDynamicGameObject(bul);
                });
            }
        }

        public Boss createBoss3(Point2D position, Vector2D direction, GameInit map) => new Boss3(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS3, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss3 : AbstractBoss
        {
            public Boss3(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot()
            {
                List<Bullet.Bullet> bullets = new List<Bullet.Bullet>();
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(0, 1), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(0, -1), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(1, 1).normal(), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(-1, 1).normal(), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(1, -1).normal(), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(-1, -1).normal(), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(1, 0), Map));
                bullets.Add(_bulletCreate.createBoss3Bullet(this.Position, new Vector2D(1, 0), Map));
                bullets.ForEach(bul => {
                    this.Map.addDynamicGameObject(bul);
                });
            }
        }

        public Boss createBoss4(Point2D position, Vector2D direction, GameInit map) => new Boss4(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS4, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss4 : AbstractBoss
        {
            public Boss4(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot() => this.Map.addDynamicGameObject(_bulletCreate.createBoss1Bullet(this.Position, newDirection(), Map));
        }

        public Boss createBoss5(Point2D position, Vector2D direction, GameInit map) => new Boss5(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS5, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss5 : AbstractBoss
        {
            public Boss5(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot() => this.Map.addDynamicGameObject(_bulletCreate.createBoss1Bullet(this.Position, newDirection(), Map));
        }

        public Boss createBoss6(Point2D position, Vector2D direction, GameInit map) => new Boss6(_bossSpeed, position, _hitBoxSize, direction, GameObjteType.BOSS6, _bossLife, _bossShootDelay, _bossDamage, _bossExam, map);

        private class Boss6 : AbstractBoss
        {
            public Boss6(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(speed, position, hitBoxSize, direction, type, life, shootDelay, impactDamage, exam, map)
            {
            }

            public override void shoot() => this.Map.addDynamicGameObject(_bulletCreate.createBoss1Bullet(this.Position, newDirection(), Map));
        }

    }
}
