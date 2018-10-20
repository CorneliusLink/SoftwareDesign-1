using System;

namespace Lesson01
{
     class RomanNumbers
    {
        
        public static string GetRomanNumber(int arabicNum)
        {
            
            if (arabicNum > 999 || arabicNum < 1)
            {
                if (arabicNum > 999)
                    return "out of value range";
                else
                    return "not existing";
            }
            else
            {
                if (arabicNum >= 100)
                {
                    int arabicOne = arabicNum%10;
                    int arabicTen = (arabicNum%100) - arabicOne;
                    int arabicHundret = arabicNum - arabicTen - arabicOne;
                    return GetHundret(arabicHundret) + GetTen(arabicTen) + GetOne(arabicOne);
                }
                else if (arabicNum >= 10)
                {
                    int arabicOne = arabicNum%10;
                    int arabicTen = (arabicNum%100) - arabicOne;
                    return GetTen(arabicTen) + GetOne(arabicOne);
                }
                else
                {
                    int arabicOne = arabicNum%10;
                    return GetOne(arabicOne);
                }

            }
        }

        public static string GetOne(int arabicOne)
        {
            string romanNum = "";
            string count = "";

            if (arabicOne < 4)
            {
                for (int i=1; i<=arabicOne; i++){
                    romanNum += "I";
                }
            }
            else if (arabicOne == 4)
            {
                romanNum = "IV";
            }
            else if (arabicOne == 5)
            {
                romanNum = "V";
            }
            else if (arabicOne < 9)
            {
                for (int i=5; i<arabicOne; i++)
                    count += "I";
                    romanNum = "V" + count;
            }
            else
            {
                romanNum = "IX";
            }

            return romanNum;
        }

        public static string GetTen(int arabicTen)
        {
             string romanNum = "";
             string count = "";

            if (arabicTen < 40)
            {
                for (int i=10; i<=arabicTen; i+=10){
                    romanNum += "X";
                }
            }
            else if (arabicTen == 40)
            {
                romanNum = "XL";
            }
            else if (arabicTen == 50)
            {
                romanNum = "L";
            }
            else if (arabicTen < 90)
            {
                for (int i=50; i<arabicTen; i+=10)
                    count += "X";
                    romanNum = "L" + count;
            }
            else
            {
                romanNum = "XC";
            }

            return romanNum;
        }

        public static string GetHundret(int arabicHundret)
        {
             string romanNum = "";
             string count = "";

            if (arabicHundret < 400)
            {
                for (int i=100; i<=arabicHundret; i+=100){
                    romanNum += "C";
                }
            }
            else if (arabicHundret == 400)
            {
                romanNum = "CD";
            }
            else if (arabicHundret == 500)
            {
                romanNum = "D";
            }
            else if (arabicHundret < 900)
            {
                for (int i=500; i<arabicHundret; i+=100)
                    count += "C";
                    romanNum = "D" + count;
            }
            else
            {
                romanNum = "CM";
            }

            return romanNum;
        }

        static void Main(string[] args)
        {
            int arabicNum;
            if(Int32.TryParse(args[0], out arabicNum))
                Console.WriteLine("The roman number is " + GetRomanNumber(arabicNum));
            else
                Console.WriteLine("input is not a number");
            
        }

    }
}