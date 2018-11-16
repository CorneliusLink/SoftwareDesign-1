using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe einen Text ein:");
            var text = Console.ReadLine();
            
            Console.WriteLine(ReverseLetters(text));
            //Console.WriteLine(ReverseWords(text));
            //Console.WriteLine(ReverseSentence(text));
        }

        static string ReverseLetters (string text)
        {
            char [] letters = new char [text.Length];
            string charString = "";

            for (int i = text.Length-1, k=0; i>=0; i--, k++)
            {
                letters[k] = text[i];
                charString += letters[k];
            }

            return charString;
        }
    }
}
