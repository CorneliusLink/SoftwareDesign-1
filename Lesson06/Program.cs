using System;

namespace Lesson06
{

    class Programm
    {   
        
        static void Main(string[] args)
        {
            /*string newQuestion = "Wann war der Mauerfall";
            string[] newAnswers = {"1998", "1999", "2010", "1989"};
            bool[] isAnswerCorrect = {false, false, false, true};
            QuizMaster quiz = new QuizMaster(
                newQuestion, newAnswers, isAnswerCorrect
            );
             */
            QuizElement quiz = new QuizElement();
            quiz.Show();
            //quizMaster.addNewQuestion(enteredQuestion);
            

            /*Quizelement quiz1 = new Quizelement();
            Console.WriteLine(quiz1);
            quiz1.question = "Wer war der erste Bundeskanzler";
            quiz1.answer = new string[] {"Brack Obama", "Helmut Kohl", "Konrad Adenauer", "Angelo Merkel"};
            quiz1.correct = 'c'; */
        }
    }
}
