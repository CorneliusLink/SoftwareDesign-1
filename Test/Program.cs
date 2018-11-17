using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text!");
            string text = Console.ReadLine();
            int length = arrayLength(text);
            Console.WriteLine(TurnWordPare(text, length));
        }

        static int arrayLength(string text)
        {
            string [] words = text.Split(' ');
            int length;

            if (words.Length % 2 == 0)
            {
                length = words.Length;
            }
            else
            {
                length = words.Length+1;
            }

            return length;
        }

        static string TurnWordPare(string text, int length){
            string outputText = ""; 
            string [] words = text.Split(' ');
            string [] newWord = new string [length];

            for(int i = 0; i <= words.Length-1; i++){
                if(i % 2 == 0)
                {
                    newWord[i+1] = words[i];
                }
                else
                {
                    newWord[i-1] = words[i];
                }
            }

            outputText = string.Join(" ", newWord);

            return outputText;
        }
    }
}
