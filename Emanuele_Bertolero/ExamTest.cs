using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_emanuele_bertolero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanuele_Bertolero
{
    [TestClass]
    public class ExamTest
    {


        [TestMethod]
        public void TestAnswerConstraint()
        {
            QuizBuilder qb = new QuizImpl.Builder(new QuestionImpl(1, "Quale animale ha meno di 4 zampe?"));
            qb.AddAnswer(new AnswerImpl(2, "Gatto", false));
            qb.AddAnswer(new AnswerImpl(3, "Canarino", true));
            Assert.ThrowsException<System.InvalidOperationException>(() => qb.Build());
        }

        [TestMethod]
        public void TestCorrectConstraint()
        {
            QuizBuilder qb = new QuizImpl.Builder(new QuestionImpl(1, "Quale animale ha meno di 4 zampe?"));
            qb.AddAnswer(new AnswerImpl(1, "Cane", false));
            qb.AddAnswer(new AnswerImpl(2, "Gatto", true));
            qb.AddAnswer(new AnswerImpl(3, "Canarino", true));
            qb.AddAnswer(new AnswerImpl(4, "Cavallo", true));
            Assert.ThrowsException<System.InvalidOperationException>(() => qb.Build());
        }

        [TestMethod]
        public void TestQuestionConstraint()
        {
            QuizBuilder qb = new QuizImpl.Builder(null);
            qb.AddAnswer(new AnswerImpl(1, "Cane", false));
            qb.AddAnswer(new AnswerImpl(1, "Gatto", false));
            qb.AddAnswer(new AnswerImpl(1, "Canarino", true));
            qb.AddAnswer(new AnswerImpl(1, "Cavallo", false));
            Assert.ThrowsException<System.InvalidOperationException>(() => qb.Build());
        }

        [TestMethod]
        public void TestQuizConstraint()
        {
            ExamBuilder eb = new ExamImpl.Builder();
            eb.SetSubject("OOP");
            eb.SetTeacher("Viroli");
            eb.SetCredits(12);
            Assert.ThrowsException<System.InvalidOperationException>(() => eb.Build());
        }


}
}
