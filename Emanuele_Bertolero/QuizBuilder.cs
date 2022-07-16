using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    public interface QuizBuilder
    {
        QuizBuilder AddAnswer(Answer anwser);
        Quiz Build();
    }
}
