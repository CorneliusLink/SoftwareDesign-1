using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe einen Text ein:");
            var text = Console.ReadLine();
            ReverseLetters(text);
            ReverseWords(text);
            ReverseSentence(text);
        }

        static string ReverseLetters(string text)
        {
            char [] letters = new char [text.Length];
            char.Reverse;
            return new String(char);
        }

        static string ReverseWords(string text)
        {
            string [] words = text.Split(' ');
            words.Reverse;
            text = String.Join(" ", words);

            return text;
        }

        static string ReverseSentence(string text)
        {
            string [] sentence = text.Split(' ');
            for(;;i--)
            {
                outputWords[i];
                
            }

            sentence.Reverse;
            return;

        }
    }
}
