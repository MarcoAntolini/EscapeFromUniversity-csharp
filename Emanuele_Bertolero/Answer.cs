using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    interface Answer
    {
        int id { get; }

        string text { get; }

        bool correct { get; }
    }
}
