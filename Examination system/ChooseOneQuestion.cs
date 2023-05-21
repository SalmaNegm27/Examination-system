namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChooseOneQuestion :Question
    {
        public List<string> Options { get; set; }
        public int CorrectOption { get; set; }
        public ChooseOneQuestion(string _header, string _body, int _marks,List<string> _option,int _correctOption) : base(_header, _body, _marks)
        {
           Options = _option;
           CorrectOption = _correctOption;
        }



        public override void Display()
        {
            base.Display();
            Console.WriteLine("Choose One \n Options: ");
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine("Correct Option Index: " + CorrectOption);
        }
    }
}
