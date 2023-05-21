namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PracticeExam : Exam
    {
        public PracticeExam(DateTime time, int numOfQuestion, Dictionary<Question, Answer> questionAnswer, Subject subject) : base(time, numOfQuestion, questionAnswer, subject)
        {
        }

        public override void ShowExam()
        {
            
        }
    }
}
