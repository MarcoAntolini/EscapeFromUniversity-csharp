using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    public interface Bullet : DynamicGameObject
    {
        int Damage { get; set; }
    }
}
