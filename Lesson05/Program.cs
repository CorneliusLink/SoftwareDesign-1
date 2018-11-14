using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text!");
            inputText(Console.ReadLine());            
        }


        static String inputText(string enterdText)
        {
            Console.WriteLine("select the method");
            Console.WriteLine("1 to turn the whole Text");
            Console.WriteLine("2 to turn every two words");
            
            int select = Int32.Parse(Console.ReadLine());
            
            switch(select){
                case 1:
                    return turnWholeText(enterdText);
                    break;
                case 2:
                    return turnTwoWords(enterdText);
                    break;
                default:
                    return "";
                    break;
            }
        }

        static String turnWholeText(string enterdText)
        {
            return "hallo 1";
        }

        static String turnTwoWords(string enterdText)
        {
            return "hallo 2";
        }
    }
}
