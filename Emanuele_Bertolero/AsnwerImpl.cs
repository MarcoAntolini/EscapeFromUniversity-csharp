using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class AnswerImpl : Answer
    {
        public int id { get; }
        public string text { get; }
        public bool correct { get; }

        public AnswerImpl(int id, string text, bool correct)
        {
            this.id = id;
            this.text = text;
            this.correct = correct;
        }

        public override string ToString()
        {
            return "[Answer n." + id + "] " + text + ", is correct: " + correct;
        }

    }
}
