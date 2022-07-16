using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_emanuele_bertolero
{
	public interface Exam
	{
		string teacherName { get; }

		string subjectName { get; }

		int credits { get; }

		Quiz GetNextQuiz();

		boolean HasNextQuiz();

		double GetProgress();

		int GetGrade();

		int GetMaxGrade();

		int GetTotal();

		bool HasPassed();
	}
}
