using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini
{
    //partial implementation, created only out of necessity

    public interface DynamicGameObject : GameObject
    {
        double Speed { get; }
        Vector2D Direction { get; set; }
        State State { get; set; }
        void update(double deltaTime);

    }
}
