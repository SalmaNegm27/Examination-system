namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChooseAllOption :Question
    {

        public List<string> Options { get; set; }
        public List<int> CorrectOptionIndex { get; set; }
        public ChooseAllOption(string _header, string _body, int _marks,List<string> options,List<int> _correctOptionIndex) : base(_header, _body, _marks)
        {
            Options = options;
            CorrectOptionIndex= _correctOptionIndex;
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine("Choose All \n Options: ");
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("Correct Option");
            foreach(var index in CorrectOptionIndex)
            {
                Console.WriteLine(index);
            }

        }
    }
}
