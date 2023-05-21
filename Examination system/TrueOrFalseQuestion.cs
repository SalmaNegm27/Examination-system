namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TrueOrFalseQuestion : Question
    {

        public bool ISTrue { get; set; }
        public TrueOrFalseQuestion(string _header, string _body, int _marks,bool _isTrue) : base(_header, _body, _marks)
        {
            ISTrue= _isTrue;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Type: True of False");
            Console.WriteLine("Is True: "+ISTrue);
        }
    }
}
