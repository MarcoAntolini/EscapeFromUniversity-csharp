using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public interface GameObject
    {
        int ID { get; set; }

        Point2D Position { get; }

        GameObjteType Type { get; }

        GameInit Map { get; }

        GameCollisionType CollisionType { get; }

        HitBox GetHitBox();
        void CollisionWith(GameObject gObj2);

        bool CollisionWithCheck(GameObject gObj2);

    }
}
