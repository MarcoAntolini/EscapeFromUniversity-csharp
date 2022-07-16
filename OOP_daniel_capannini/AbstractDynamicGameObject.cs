using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public abstract class AbstractDynamicGameObject : DynamicGameObject
    {
        private Point2D _hitBoxSize;

        public AbstractDynamicGameObject(GameObjteType type, Point2D position, Point2D hitBoxSize, double speed, Vector2D direction, GameInit map)
        {
            Type = type;
            Position = position;
            _hitBoxSize = hitBoxSize;
            Speed = speed;
            Direction = direction;
            Map = map;
        }

        public GameObjteType Type { get; set; }
        public Point2D Position { get; set; }
        public double Speed { get; }
        public Vector2D Direction { get; set; }
        public GameInit Map { get; }
        public GameCollisionType collisionType { get; }
        public int ID { get; set; }
        public State State { get; set; }

        public GameCollisionType CollisionType { get; }

        public void Move(double deltaTime)
        {

        }

        public abstract void Update(double deltaTime);
        public abstract void CollisionWith(GameObject gObj2);
        public bool CollisionWithCheck(GameObject gObj2) => true;

        HitBox GameObject.GetHitBox()
        {
            return null;
        }
    }
}
