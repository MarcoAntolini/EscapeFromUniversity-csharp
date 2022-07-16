using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
    class QuizImpl : Quiz
    {
        private readonly Question question { get; }
        private readonly Dictionary<int, Answer> anwsers;
        private bool answered;
        private bool? correct;

        private QuizImpl(Question question, Dictionary<int, Answer> anwsers)
        {
            this.question = question;
            this.anwsers = anwsers;
        }

        public override int GetID()
        {
            return question.getID();
        }

        public Dictonary<int, Answer> GetAllAnswers()
        {
            return anwsers;
        }

        public bool HasBeenAnswered()
        {
            return answered;
        }

        public bool GiveAnAnswer(int choice)
        {
            answered = true;
            correct = Optional.of(anwsers.get(choice).isCorrect());
            return correct.get();
        }

        public override string ToString()
        {
            return "[Quiz n." + GetID() + "] " + question.ToString() + GetAllAnwsers().ToString();
        }
        public override Optional<Boolean> hasAnsweredWell()
        {
            return correct;
        }

        public static class Builder : QuizBuilder
        {
            private Question question;
            private Dictionary<int, Answer> anwsers = new Dictionary<int, Answer>();

            public Builder(Question question)
            {
                this.question = question;
            }

            public QuizBuilder AddAnswer(Answer anwser)
            {
                anwsers.put(anwser.getId(), anwser);
                return this;
            }
            
            public Quiz Build()
            {
                if (question == null)
                {
                    throw new InvalidOperationException("This quiz does not have a correctly set question");
                }
                if (anwsers.values().stream().filter(ans->ans.isCorrect()).count() != 1)
                {
                    throw new InvalidOperationException("In each quiz there must be one and only one correct answer");
                }
                if (anwsers.size() != 4)
                {
                    throw new InvalidOperationException("This quiz does not have exactly 4 answers");
                }
                return new QuizImpl(question, anwsers);
            }

        }

    }

}

