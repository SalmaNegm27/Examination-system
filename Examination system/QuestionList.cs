namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuestionList : List<Question>
    {
        public new void Add(Question question, string filePath)
        {
            base.Add(question);
            LogObject(question, filePath);
        }
        public void LogObject(Question question, string filePath)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"Header:{question.Header}");
                writer.WriteLine($"Body:{question.Body}");
                writer.WriteLine($"Marks:{question.Marks}");
                
            }
        }
    }
}
