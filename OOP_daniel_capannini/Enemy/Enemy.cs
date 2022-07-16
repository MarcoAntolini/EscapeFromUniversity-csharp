using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    public interface Enemy : DynamicGameObject
    {
        int Life { get; }

        void MaybeShoot(double deltaTime);

        void TakeDamage(int damage);
    }
}
