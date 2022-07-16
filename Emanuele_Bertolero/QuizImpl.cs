using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    /// <summary>
    /// QuizImpl is the implementation of the Quiz interface.
    /// </summary>
    class QuizImpl : Quiz
    {
        public Question question { get; }
        private Dictionary<int, Answer> answers;
        private bool answered;
        private bool? correct;

        /// <summary>
        /// A constructor for QuizImpl.
        /// </summary>
        /// <param name="question">The question of the quiz</param>
        /// <param name="answers">The answers of the quiz</param>
        private QuizImpl(Question question, Dictionary<int, Answer> answers)
        {
            this.question = question;
            this.answers = answers;
        }

        /// <summary>
        /// Get the ID of the quiz.
        /// </summary>
        /// <returns>The numeric ID of the question</returns>
        public int GetID()
        {
            return question.id;
        }

        /// <summary>
        /// Get all answers of the quiz.
        /// </summary>
        /// <returns>All answers in this quiz numbered with their ID</returns>
        public Dictionary<int, Answer> GetAllAnswers()
        {
            return answers;
        }

        /// <summary>
        /// Check if the quiz has been answered.
        /// </summary>
        /// <returns>True if an answer was given by the user</returns>
        public bool HasBeenAnswered()
        {
            return answered;
        }

        /// <summary>
        /// Try to give an answer to the quiz.
        /// </summary>
        /// <param name="choice">choice The numeric ID of the response you want to select</param>
        /// <returns>True if the selected answer is correct, false otherwise</returns>
        public bool GiveAnAnswer(int choice)
        {
            answered = true;
            correct = answers[choice].correct;
            return correct.Value;
        }

        public override string ToString()
        {
            return "[Quiz n." + GetID() + "] " + question.ToString() + GetAllAnswers().ToString();
        }

        /// <summary>
        /// Check if the quiz has been answered correctly.
        /// </summary>
        /// <returns>rue if the quiz is answered correctly</returns>
        public bool? HasAnsweredWell()
        {
            return correct;
        }

        public class Builder : QuizBuilder
        {
            private Question question;
            private Dictionary<int, Answer> answers = new Dictionary<int, Answer>();

            /// <summary>
            /// A constructor for the quiz Builder.
            /// </summary>
            /// <param name="question">The question of the quiz</param>
             public Builder(Question question)
            {
                this.question = question;
            }

            /// <summary>
            /// Add an answer to the quiz.
            /// </summary>
            /// <param name="anwser">One of the four questions you want to add.</param>
            /// <returns>The builder.</returns>
            public QuizBuilder AddAnswer(Answer anwser)
            {
                answers.Add(anwser.id, anwser);
                return this;
            }

            /// <summary>
            /// Check and build the quiz.
            /// </summary>
            /// <returns>The quiz complete with all necessary parts</returns>
            public Quiz Build()
            {
                if (question == null)
                {
                    throw new InvalidOperationException("This quiz does not have a correctly set question");
                }
                if (answers.Values.Where(ans => ans.correct).Count() != 1)
                {
                    throw new InvalidOperationException("In each quiz there must be one and only one correct answer");
                }
                if (answers.Count != 4)
                {
                    throw new InvalidOperationException("This quiz does not have exactly 4 answers");
                }
                return new QuizImpl(question, answers);
            }

        }

    }

}

