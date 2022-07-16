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
        void SetFinalMark(int result);

        void IncreaseCredits(int credits);

        void TakeDamage(int damage);

    }
}
