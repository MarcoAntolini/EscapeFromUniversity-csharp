using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    public interface Boss : Enemy
    {

        BossState BossState { get; set; }

        int Life { get; }

        int ImpactDamage { get; }

        string BossExam { get; }

        void setQuizResult(int result);

        void kill();

        void setQuizCredits(int credits);
    }
}
