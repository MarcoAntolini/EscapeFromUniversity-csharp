using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    public interface BossFactory
    {
        Boss createBoss1(Point2D position, Vector2D direction, GameInit map);
        Boss createBoss2(Point2D position, Vector2D direction, GameInit map);
        Boss createBoss3(Point2D position, Vector2D direction, GameInit map);
        Boss createBoss4(Point2D position, Vector2D direction, GameInit map);
        Boss createBoss5(Point2D position, Vector2D direction, GameInit map);
        Boss createBoss6(Point2D position, Vector2D direction, GameInit map);

    }
}
