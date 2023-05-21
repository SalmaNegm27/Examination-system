namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Question question = new ChooseAllOption("sss", "ssss", 1,new List<string>(){"1","2","3"}, new List<int> { 1,2});
            QuestionList questions = new QuestionList();
            questions.Add(new ChooseAllOption("sss", "ssss", 1, new List<string>() { "1", "2", "3" }, new List<int> { 1, 2 }), @"E:\MYITI\OOP\OOPD07-Extension\lab\Examination system\question.txt");
           
            
       
            
       }
    }
}