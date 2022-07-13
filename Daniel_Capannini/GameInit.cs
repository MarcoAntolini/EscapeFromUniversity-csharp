using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public interface GameInit
{
        Player Player { get; }

        void deleteGameObject(GameObject gObj2);

        State State { get; set; }

        void goQuiz(Enemy.Boss boss);

        void addDynamicGameObject(DynamicGameObject dObj);

    }
}
