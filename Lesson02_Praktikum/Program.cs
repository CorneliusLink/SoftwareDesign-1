using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialisierung
            int i = 12;
            double pi = 3.14;
            string salute = "Hallo World!";

            Console.WriteLine(i + " " + pi + " " + salute);

            //Typinferenz
            var i1 = 12;
            var pi1 = 3.14d;
            var salute2 = "Hallo World";

            Console.WriteLine(i1 + " " + pi1 + " " + salute2);
            
            //Arrays
            int[] ia = new int[10];
            char[] ca = new char[30];
            double[] da = new double[12];

            /*
                ToDo:
                Variablenname: ia -> Typ: integer   -> 10 Werte
                Variablenname: ca -> Typ: character -> 30 Werte(einzelne Zeichen)
                Variablenname: da -> Typ: double    -> 12 Fließkomma Werte
            */

            //Zugriff auf einzelne Array-Speicherplätze

            /*
                ToDo:

                int ergebnis = ia[2] * ia[8] + ia[4];

                Was steht in der Variable ergebnis? -> 13
            */

            /*
            
                Erzeugt einen Array vom Grund-Typ double, der drei Speicherplätze enthält in denen in der angegebenen Reihenfolge

                die Zahl PI,
                die Eulersche Zahl und
                die Kepler-Konstante

                enthalten sind
            */
            //Frage 1: wie soll ich die Eulersche Zahl in einer Zahl darstellen ohne es in einer Methode zu berechnen oder die Kepler-Konstante (2,97*10^-19)?
            //Frage 2: wie kann ich in C# konstanten deklarieren und geht das überhaupt mit Arrays in Java wäre es für variablen public final double PI = 3.14; 
            double[] constant = {3.14159265359};


            int[] iarray = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};

            Console.WriteLine(iarray.Length);

            // Strings
            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            
            string meinString = "Dies ist ein String";
            char zeichen = meinString[5];
            
            Console.WriteLine(zeichen);


            //if-else
            int zahlA = int.Parse(Console.ReadLine());
            int zahlB = int.Parse(Console.ReadLine());

            if (zahlA < zahlB){
                Console.WriteLine("zahlA ist kleiner zahlB");
            }
            else{
                Console.WriteLine("zahlA ist größer zahlB");
            }

            if (zahlA > 3 && zahlB == 6){
                Console.WriteLine("du hast gewonnen");
            }
            else{
                Console.WriteLine("Loser");
            }

            //switch-case
        
        }
    }

}