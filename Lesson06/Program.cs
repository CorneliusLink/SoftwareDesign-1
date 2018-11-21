using System;

namespace Lesson06
{

    class Programm
    {
        static void Main(string[] args)
        {
            Quizelement quiz1 = new Quizelement();
            Console.WriteLine(quiz1);
            quiz1.question = "Wer war der erste Bundeskanzler";
            quiz1.answer = new string[] {"Brack Obama", "Helmut Kohl", "Konrad Adenauer", "Angelo Merkel"};
            quiz1.correct = 'c';
            
        }
    }
}
