namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Answer
    {
        public string TheAnswer{ get; set; }

        public Answer(string theAnswer)
        {
            TheAnswer = theAnswer;
        }

        public override string ToString()
        {
            return $"{TheAnswer}";
        }
    }
}
