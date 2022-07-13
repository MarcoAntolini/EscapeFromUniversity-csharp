using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public interface Player : DynamicGameObject
    {
        void setFinalMark(int result);

        void increaseCredits(int credits);

        void takeDamage(int damage);

    }
}
