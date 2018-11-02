using System;

namespace Lesson03_Praktikum
{
    class Program
    {
        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem){
            
            int result = 0;
            int factor = 1;

            int [] numbers = {number, fromSystem, toSystem};
            
            if (result == 0){
                while (numbers[0] != 0)
                {
                    int digit = numbers[0] % 10;
                    numbers[0] /= 10;
                    result += factor * digit;
                    factor *= numbers[1];
                }
                return result;
            }
            else{
                while (result != 0)
                {
                    int digit = result % numbers[2];
                    result /= numbers[2];
                    result += factor * digit;
                    factor *= 10;
                }
                return result;
            }
        }

        static void Main(string[] args)
        {

            try{
                Console.WriteLine("Geben Sie 3 Dezimal Werte ein: ");
                int number = Int32.Parse(Console.ReadLine());
                int fromSystem = Int32.Parse(Console.ReadLine());
                int toSystem = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Das Ergebnis ist " + ConvertNumberFromSystemToSystem(number, fromSystem, toSystem));
            }
            catch(Exception){
                Console.WriteLine("Ein Fehler ist aufgetretten!");
            }
        }
    }
}
