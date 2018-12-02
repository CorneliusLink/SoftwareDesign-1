using System;
using System.Collections.Generic;

namespace Lesson06
{
    public class QuizElement
    {
        Dictionary<Question, Answer[]> lisOfQuiz = new Dictionary<Question, Answer[]>()
        {
            {
                new Question("Wie lautet die Hauptstadt von Frankrei?"), 
                new Answer[]
                { 
                    new Answer("Madrid", false),
                    new Answer("Paris", true),
                    new Answer("Berlin", false),
                    new Answer("Rom", false)
                }
            },
            {
                new Question("Welcher Agent steht im Zusammenhang mit der 'Lizenz zum Töten?"), 
                new Answer[]
                { 
                    new Answer("Kingsman", false),
                    new Answer("Ethan Hunt", false),
                    new Answer("James Bond", true),
                    new Answer("Jason Born", false)
                }
            },
            {
                new Question("Welches Dateiformat öffnet man typischerweise mit dem Acrobat Reader?"), 
                new Answer[]
                { 
                    new Answer("PDF", true),
                    new Answer("EXE", false),
                    new Answer("BAT", false),
                    new Answer("ARF", false)
                }
            },
            {
                new Question("Welches Betriebssystem stammt von Apple?"), 
                new Answer[]
                { 
                    new Answer("Zuse", false),
                    new Answer("Windows", false),
                    new Answer("iOS", true),
                    new Answer("Linux", false)
                }
            },
            {
                new Question("Wieviele Nieren hat ein Mensch im Normalfall?"), 
                new Answer[]
                { 
                    new Answer("4", false),
                    new Answer("2", true),
                    new Answer("3", false),
                    new Answer("1", false)
                }
            }
        };


        public void Show(){
            Random randomNumber = new Random();
            int number = randomNumber.Next(0,lisOfQuiz.Count);
            Console.WriteLine(lisOfQuiz);
            //string question = lisOfQuiz.Key.ToString();

        }
    }
}
