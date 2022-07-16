using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class ExamImpl : Exam
    {
        private readonly Dictionary<int, Quiz> exam;
        private readonly string teacherName { get; }
        private readonly string subjectName { get; }
        private readonly int credits { get; }
        private int currentQuiz;
        private static readonly int MAXSCORE = 30;
        private static readonly int PASSEDSCORE = 18;

        public ExamImpl(Dictionary<int, Quiz> exam, string teacherName, string subjectName, int credits)
        {
            this.exam = exam;
            this.teacherName = teacherName;
            this.subjectName = subjectName;
            this.credits = credits;
        }

        private int CompletedQuiz()
        {

            return (int)exam.entrySet().stream().filter(q->q.getValue().hasBeenAnswered()).count();
        }

        public Quiz GetNextQuiz()
        {
            currentQuiz++;
            return exam[currentQuiz];
        }

        public bool HasNextQuiz()
        {
            return currentQuiz + 1 <= exam.Count;
        }

        public double GetProgress()
        {
            return (double)((double)(this.completedQuiz()) / exam.size());
        }

        public int GetGrade()
        {
            return (int)this.getMaxGrade() / this.getTotal() * (int)this.exam.entrySet().stream().filter(q->q.getValue().hasBeenAnswered() && q.getValue().hasAnsweredWell().get()).count();
        }

        public int GetMaxGrade()
        {
            return MAXSCORE;
        }

        public int GetTotal()
        {
            return exam.size();
        }

        public bool HasPassed()
        {
            return this.getGrade() >= PASSEDSCORE;
        }

        public class Builder : ExamBuilder
        {
            private readonly Dictionary<int, Quiz> exam = new Dictionary<int, Quiz>();
            private int credits;
            private string teacherName;
            private string subjectName;

            public ExamBuilder AddQuiz(Quiz quiz)
            {
                if (exam.ContainsKey(quiz.getID()))
                {
                    throw new InvalidOperationException("There is already a quiz with id " + quiz.GetID() + " in this package");
                }
                else
                {
                    exam.Add(quiz.getID(), quiz);
                }
                return this;
            }

            public ExamBuilder SetTeacher(string teacherName)
            {
                this.teacherName = teacherName;
                return this;
            }

            public ExamBuilder setCredits(int credits)
            {
                this.credits = credits;
                return this;
            }

            public ExamBuilder setSubject(string subjectName)
            {
                this.subjectName = subjectName;
                return this;
            }

            public override Exam build()
            {
                if (this.teacherName == null)
                {
                    throw new InvalidOperationException("This competition does not have a correctly set teacher");
                }
                if (this.credits == 0)
                {
                    throw new InvalidOperationException("This competition does not have a correctly set credits");
                }
                if (this.subjectName == null)
                {
                    throw new InvalidOperationException("This competition does not have a correctly set subject");
                }
                if (this.exam.size() < 1)
                {
                    throw new InvalidOperationException("This competition must have at least one quiz");
                }
                return new ExamImpl(exam, teacherName, subjectName, credits);
            }

        }
    }
}
