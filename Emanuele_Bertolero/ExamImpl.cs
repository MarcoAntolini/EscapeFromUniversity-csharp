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

        /// <summary>
        /// A constructor for ExamImpl.
        /// </summary>
        /// <param name="exam">The quizes set</param>
        /// <param name="teacherName">The name of the teacher of the exam/param>
        /// <param name="subjectName">The subject matter on which the exam is focused</param>
        /// <param name="credits">The credits of this exam/param>
        public ExamImpl(Dictionary<int, Quiz> exam, string teacherName, string subjectName, int credits)
        {
            this.exam = exam;
            this.teacherName = teacherName;
            this.subjectName = subjectName;
            this.credits = credits;
        }

        /// <summary>
        /// Get the completed quiz.
        /// </summary>
        /// <returns>The number of completted quiz</returns>
        private int CompletedQuiz()
        {
            return exam.Values.Where(q => q.HasBeenAnswered()).Count();
        }

        /// <summary>
        /// Get the next quiz.
        /// </summary>
        /// <returns>Next quiz if available</returns>
        public Quiz GetNextQuiz()
        {
            currentQuiz++;
            return exam[currentQuiz];
        }

        /// <summary>
        /// Check if there is another quiz.
        /// </summary>
        /// <returns>True if there are still quizzes to be taken</returns>
        public bool HasNextQuiz()
        {
            return currentQuiz + 1 <= exam.Count;
        }

        /// <summary>
        /// Get the general progress.
        /// </summary>
        /// <returns>Percentage of completed quizzes out of total</returns>
        public double GetProgress()
        {
            return (double)((double)(this.CompletedQuiz()) / exam.Count);
        }

        /// <summary>
        /// Get the current grade.
        /// </summary>
        /// <returns>Score representing quizzes answered correctly</returns>
        public int GetGrade()
        {
            return (int)this.GetMaxGrade() / this.GetTotal() * (int)exam.Values.Where(q => q.HasBeenAnswered() && q.HasAnsweredWell().Value).Count();         
        }

        /// <summary>
        /// Get the max grade.
        /// </summary>
        /// <returns>Max score for the exam</returns>
        public int GetMaxGrade()
        {
            return MAXSCORE;
        }

        /// <summary>
        /// Get total number of quizzes
        /// </summary>
        /// <returns>The total number of quizzes</returns>
        public int GetTotal()
        {
            return exam.Count;
        }

        /// <summary>
        /// Check if passed the exam.
        /// </summary>
        /// <returns>True if the score is greater than the sufficent grade</returns>
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

            /// <summary>
            /// Add a quiz to the exam.
            /// </summary>
            /// <param name="quiz">Quiz you want to add to the exam</param>
            /// <returns>The builder</returns>
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

            /// <summary>
            /// Set the name of the teacher of the exam.
            /// </summary>
            /// <param name="teacherName">The name of the teacher of the exam.</param>
            /// <returns>The builder</returns>
            public ExamBuilder SetTeacher(string teacherName)
            {
                this.teacherName = teacherName;
                return this;
            }

            /// <summary>
            /// Set the credits of this exam.
            /// </summary>
            /// <param name="credits">The credits of this exam.</param>
            /// <returns>The builder</returns>
            public ExamBuilder SetCredits(int credits)
            {
                this.credits = credits;
                return this;
            }

            /// <summary>
            /// Set the subject matter on which the exam is focused.
            /// </summary>
            /// <param name="subjectName">The subject matter on which the exam is focused</param>
            /// <returns>The builder</returns>
            public ExamBuilder SetSubject(string subjectName)
            {
                this.subjectName = subjectName;
                return this;
            }


            /// <summary>
            /// Check and build the exam.
            /// </summary>
            /// <returns>The exam object complete with all mandatory parts</returns>
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
