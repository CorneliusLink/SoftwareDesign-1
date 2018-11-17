using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen Satz eingeben:");
            var text = Console.ReadLine();

            string senctence = ReverseSentence(text);
            string output = ReverseWords(text);
            string letters = ReverseLetters(text);

            Console.WriteLine(senctence);
            Console.WriteLine(output);
            Console.WriteLine(letters);
        }

        static string ReverseLetters(string text){
            string [] wordText = text.Split(' ');
            string [] outputText = new string [wordText.Length];
            string wordIsTurned = "";
            string output = "";

            for(int i = 0; i <= wordText.Length-1; i++)
            {
                wordIsTurned = ReverseSentence(wordText[i]);
                outputText[i] = wordIsTurned;
            }
            
            output = string.Join(" ", outputText);

            return output;
        } 

        static string ReverseSentence(string text)
        {
            char [] letters = text.ToCharArray();
            
            Array.Reverse(letters);
            text = new String(letters);

            return text;
        }

        static string ReverseWords(string text)
        {
            string[] words = text.Split(' ');
            
            Array.Reverse(words);
            text = string.Join(" ", words);

            return text;
        }
    }
}
