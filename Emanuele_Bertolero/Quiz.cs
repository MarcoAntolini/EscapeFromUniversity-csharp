using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    interface Quiz
    {
        int GetID();

        Question question { get; }

        Dictonary<int, Answer> GetAllAnswers();

        bool HasBeenAnswered();

        Optional<bool> HasAnsweredWell();

        bool GiveAnAnswer(int choice);
    }
}
