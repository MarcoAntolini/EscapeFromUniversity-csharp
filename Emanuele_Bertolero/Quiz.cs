using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    public interface Quiz
    {
        int GetID();

        Question question { get; }

        Dictionary<int, Answer> GetAllAnswers();

        bool HasBeenAnswered();

        bool? HasAnsweredWell();

        bool GiveAnAnswer(int choice);
    }
}
