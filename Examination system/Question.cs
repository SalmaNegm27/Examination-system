namespace Examination_system
{
    using System;
    

    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public Question(string _header ,string _body ,int _marks)
        {
           Header= _header;
            Body= _body;
            Marks= _marks;
        }


        public virtual void Display()
        {
            Console.WriteLine($"{Header}({Marks}Mark)\n{Body}");
   
        }
       
    }


}
