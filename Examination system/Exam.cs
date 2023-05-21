namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Formats.Asn1;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Mode
    {
        Starting,
        Queued,
        Finished
    }
    public abstract class Exam
    {
        public DateTime Time { get; set; }
        public int NumOfQuestion { get; set; }
        public Dictionary<Question,Answer> QuestionAnswer { get; set; }
        public Subject Subject { get; set; }
        public Mode Mode { get; set; }
        public Exam(DateTime time, int numOfQuestion, Dictionary<Question, Answer> questionAnswer,Subject subject)
        {
            Time = time;
            NumOfQuestion = numOfQuestion;
            QuestionAnswer = questionAnswer;
            Subject = subject;
        }
        

        public abstract  void ShowExam();
        //{
        //    Console.WriteLine($"Time{Time}\n{NumOfQuestion}");
        //    foreach( var question in QuestionAnswer )
        //    {
        //        Console.WriteLine(question.Key.Body);
        //        Console.WriteLine(question.Value.TheAnswer);
                
        //    }

        //}
    }
}
