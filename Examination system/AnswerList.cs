namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AnswerList : List<Answer>
    {
        public new void Add(Answer answer,string path)
        {
            base.Add(answer);
            LogObject(answer, path);
        }
        public void LogObject(Answer answer, string filePath)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{answer.TheAnswer}");

            }
        }
}
