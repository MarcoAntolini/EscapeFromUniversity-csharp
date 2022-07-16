using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class QuizImpl : Quiz
    {
        public Question question { get; }
        private Dictionary<int, Answer> answers;
        private bool answered;
        private bool? correct;

        private QuizImpl(Question question, Dictionary<int, Answer> answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public int GetID()
        {
            return question.id;
        }

        public Dictionary<int, Answer> GetAllAnswers()
        {
            return answers;
        }

        public bool HasBeenAnswered()
        {
            return answered;
        }

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
        public bool? HasAnsweredWell()
        {
            return correct;
        }

        public class Builder : QuizBuilder
        {
            private Question question;
            private Dictionary<int, Answer> answers = new Dictionary<int, Answer>();

            public Builder(Question question)
            {
                this.question = question;
            }

            public QuizBuilder AddAnswer(Answer anwser)
            {
                answers.Add(anwser.id, anwser);
                return this;
            }
            
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

