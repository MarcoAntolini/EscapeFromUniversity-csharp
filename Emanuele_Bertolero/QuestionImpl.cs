using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    /// <summary>
    /// QuestionImpl is the implementation of the Question interface.
    /// </summary>
    class QuestionImpl : Question
    {
        public int id { get; }
        public string text { get; }

        /// <summary>
        /// A constructor for QuestionImpl.
        /// </summary>
        /// <param name="id">The numeric ID of the question</param>
        /// <param name="text">The actual text of the question/param>
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
