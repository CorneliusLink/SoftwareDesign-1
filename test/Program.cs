using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "";
            string test = "";
            int arabicNum = Int32.Parse(args[0]);
            for(int i=5; i<arabicNum; i++){
                test += "I";
                roman = "V"+test;
            }
            Console.WriteLine(roman);
        }
    }
}
