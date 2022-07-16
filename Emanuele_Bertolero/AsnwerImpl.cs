using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    /// <summary>
    /// AnswerImpl is the implementation of the Answer interface
    /// </summary>
    class AnswerImpl : Answer
    {
        public int id { get; }
        public string text { get; }
        public bool correct { get; }

        /// <summary>
        /// A constructor for AnswerImpl.
        /// </summary>
        /// <param name="id">Response identification number</param>
        /// <param name="text">Actual text of the response we are representing</param>
        /// <param name="correct">Set to true if it is a correct answer.</param>
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
