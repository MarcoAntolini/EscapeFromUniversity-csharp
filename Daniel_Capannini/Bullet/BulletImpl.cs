using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    public class BulletImpl : AbstractDynamicGameObject, Bullet
    {
        public int Damage { get; set; }

        private static Point2D _hitBoxSize = new Point2D(0, 0);

        public BulletImpl(GameObjteType type, Point2D position, double speed, Vector2D direction, int damage, GameInit map) : base(type, position, _hitBoxSize, speed, direction, map) => Damage = damage;

        public override void update(double deltaTime) => this.move(deltaTime);

        public override void collisionWith(GameObject gObj2)
        {
            if (this.collisionWithCheck(gObj2))
            {
                switch (gObj2.CollisionType)
                {
                    case GameCollisionType.OBSTACLE:
                        this.Map.deleteGameObject(this);
                        break;
                    case GameCollisionType.BULLET:
                        if (this.collisionType == GameCollisionType.IMMUNE_BULLET)
                            this.Map.deleteGameObject(gObj2);
                        break;
                    case GameCollisionType.ENTITY:
                        if (gObj2.Type == GameObjteType.PLAYER && this.Type != GameObjteType.BULLET_PLAYER)
                        {
                            Player player = (Player)gObj2;
                            player.takeDamage(this.Damage);
                            this.Map.deleteGameObject(this);
                        }
                        else if (gObj2.Type != GameObjteType.PLAYER && this.Type == GameObjteType.BULLET_PLAYER)
                        {
                            Enemy.Enemy enemy = (Enemy.Enemy)gObj2;
                            enemy.takeDamage(this.Damage);
                            this.Map.deleteGameObject(this);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
