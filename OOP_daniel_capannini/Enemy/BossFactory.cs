using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    public interface BossFactory
    {
        Boss CreateBoss1(Point2D position, Vector2D direction, GameInit map);
        Boss CreateBoss2(Point2D position, Vector2D direction, GameInit map);
        Boss CreateBoss3(Point2D position, Vector2D direction, GameInit map);
        Boss CreateBoss4(Point2D position, Vector2D direction, GameInit map);
        Boss CreateBoss5(Point2D position, Vector2D direction, GameInit map);
        Boss CreateBoss6(Point2D position, Vector2D direction, GameInit map);

    }
}
