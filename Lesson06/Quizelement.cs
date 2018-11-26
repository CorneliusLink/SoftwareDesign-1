using System;
using System.Collections.Generic;

namespace Lesson06
{
    public class QuizElement
    {
        List<Question> questions = new List<Question>()
        {
            new Question("Wie lautet die Hauptstadt von Frankrei?"),
            new Question("Welcher Agent steht im Zusammenhang mit der 'Lizenz zum Töten?"),
            new Question("Welches Dateiformat öffnet man typischerweise mit dem Acrobat Reader?"),
            new Question("Welches Betriebssystem stammt von Apple?"),
            new Question("Wieviele Nieren hat ein Mensch im Normalfall?")            
        };

        Dictionary<int, Answer[]> quiz = new Dictionary<int, Answer[]>()
        {
            {
                1, 
                new Answer[]
                { 
                    new Answer("Madrid", false),
                    new Answer("Paris", true),
                    new Answer("Berlin", false),
                    new Answer("Rom", false)
                }
            },
            {
                2, 
                new Answer[]
                { 
                    new Answer("Kingsman", false),
                    new Answer("Ethan Hunt", false),
                    new Answer("James Bond", true),
                    new Answer("Jason Born", false)
                }
            },
            {
                3, 
                new Answer[]
                { 
                    new Answer("PDF", true),
                    new Answer("EXE", false),
                    new Answer("BAT", false),
                    new Answer("ARF", false)
                }
            },
            {
                4, 
                new Answer[]
                { 
                    new Answer("Zuse", false),
                    new Answer("Windows", false),
                    new Answer("iOS", true),
                    new Answer("Linux", false)
                }
            },
            {
                5, 
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
            int number = randomNumber.Next(0,questions.Count);
            //string question;
            Console.WriteLine(questions[number].question);

            Console.WriteLine(quiz[number]);

        }
    }
}
