using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class ExamImpl : Exam
    {
        private Dictionary<int, Quiz> exam;
        public string teacherName { get; }
        public string subjectName { get; }
        public int credits { get; }
        private int currentQuiz;
        private static int MAXSCORE = 30;
        private static int PASSEDSCORE = 18;

        public ExamImpl(Dictionary<int, Quiz> exam, string teacherName, string subjectName, int credits)
        {
            this.exam = exam;
            this.teacherName = teacherName;
            this.subjectName = subjectName;
            this.credits = credits;
        }

        private int CompletedQuiz()
        {
            return exam.Values.Where(q => q.HasBeenAnswered()).Count();
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
            return (double)((double)(this.CompletedQuiz()) / exam.Count);
        }

        public int GetGrade()
        {
            return (int)this.GetMaxGrade() / this.GetTotal() * (int)exam.Values.Where(q => q.HasBeenAnswered() && q.HasAnsweredWell().Value).Count();         
        }

        public int GetMaxGrade()
        {
            return MAXSCORE;
        }

        public int GetTotal()
        {
            return exam.Count;
        }

        public bool HasPassed()
        {
            return this.GetGrade() >= PASSEDSCORE;
        }

        public class Builder : ExamBuilder
        {
            private readonly Dictionary<int, Quiz> exam = new Dictionary<int, Quiz>();
            private int credits;
            private string teacherName;
            private string subjectName;

            public ExamBuilder AddQuiz(Quiz quiz)
            {
                if (exam.ContainsKey(quiz.GetID()))
                {
                    throw new InvalidOperationException("There is already a quiz with id " + quiz.GetID() + " in this package");
                }
                else
                {
                    exam.Add(quiz.GetID(), quiz);
                }
                return this;
            }

            public ExamBuilder SetTeacher(string teacherName)
            {
                this.teacherName = teacherName;
                return this;
            }

            public ExamBuilder SetCredits(int credits)
            {
                this.credits = credits;
                return this;
            }

            public ExamBuilder SetSubject(string subjectName)
            {
                this.subjectName = subjectName;
                return this;
            }

            public Exam Build()
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
                if (this.exam.Count < 1)
                {
                    throw new InvalidOperationException("This competition must have at least one quiz");
                }
                return new ExamImpl(exam, teacherName, subjectName, credits);
            }

        }
    }
}
