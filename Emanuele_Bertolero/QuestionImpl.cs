using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class QuestionImpl : Question
    {
        private readonly int id { get; }
        private readonly string text { get; }
        public QuestionImpl(int id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public override string ToString()
        {
            return "[Question n." + id + "] " + text;
        }
    }
}
