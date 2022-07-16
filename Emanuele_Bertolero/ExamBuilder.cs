using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    interface ExamBuilder
    {
        ExamBuilder AddQuiz(Quiz quiz);

        ExamBuilder SetTeacher(string teacherName);

        ExamBuilder SetSubject(string subjectName);

        ExamBuilder SetCredits(int credits);

        Exam Build();
    }
}
