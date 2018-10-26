using System;

namespace test
{
    class Program
    {

        public static void Initialisierung(){
            //Initialisierung
            int i = 12;
            double pi = 3.14;
            string salute = "Hallo World!";
            Console.WriteLine("Initialisierung");
            Console.WriteLine(i + " " + pi + " " + salute);
        }

        public static void Typinferenz(){
            //Typinferenz
            var i1 = 12;
            var pi1 = 3.14d;
            var salute2 = "Hallo World";

            Console.WriteLine("Typ Inferenz");
            Console.WriteLine(i1 + " " + pi1 + " " + salute2);
        }

        public static void Arryas(){
            
            Console.WriteLine("Arrays");
            //Arrays
            int[] ia = new int[10];
            char[] ca = new char[30];
            double[] da = new double[12];

            //int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};

            ia[0] = 1;
            ia[1] = 0;
            ia[2] = 2;
            ia[3] = 9;
            ia[4] = 3;
            ia[5] = 8;
            ia[6] = 4;
            ia[7] = 7;
            ia[8] = 5;
            ia[9] = 6;
            
            /*
                ToDo:
                Variablenname: ia -> Typ: integer   -> 10 Werte
                Variablenname: ca -> Typ: character -> 30 Werte(einzelne Zeichen)
                Variablenname: da -> Typ: double    -> 12 Fließkomma Werte
            */

            //Zugriff auf einzelne Array-Speicherplätze

            
            int ergebnis = ia[2] * ia[8] + ia[4];

            Console.WriteLine(ergebnis);
            

            /*
            
                Erzeugt einen Array vom Grund-Typ double, der drei Speicherplätze enthält in denen in der angegebenen Reihenfolge

                die Zahl PI,
                die Eulersche Zahl und
                die Kepler-Konstante

                enthalten sind
            */
            //Frage 1: wie kann ich in C# konstanten deklarieren und geht das überhaupt mit Arrays in Java wäre es für variablen public final double PI = 3.14; 
            double[] constant = {3.14159265359,  2.718, 2.97*(10^-19)};
            Console.WriteLine(constant[0] + " " + constant[1] + " " + constant[2]);
            Console.WriteLine(ia.Length);
        }

        public static void Zeichenkette(){
            
            Console.WriteLine("Strings");
            // Strings
            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            
            string meinString = "Dies ist ein String";
            char zeichen = meinString[5];
            
            Console.WriteLine(zeichen);
        }

        public static void Anweisungen(){
            
            Console.WriteLine("Verzweigung if-else");
            //if-else
            Console.WriteLine("Gib eine Zahl für A ein:");
            int zahlA = int.Parse(Console.ReadLine());
            Console.WriteLine("Gib eine Zahl für B ein:");
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
        }

        public static void Auswahl(){
            Console.WriteLine("Verzweigung switch-case");

            Console.WriteLine();
            Console.WriteLine("Fischers Fritz, Fischt frische Fische. Frische Fische, fischt Fischers Fritz.");
            Console.WriteLine("Welchen Namen trägt die Person im Text oder was tut die Person?");

            string word = Console.ReadLine(); 
            
            switch(word){
                case "Fischer":
                    Console.WriteLine(word + " ist der Nachname");
                    break;
                case "Fritz":
                    Console.WriteLine(word + " ist sein Vorname");
                    break;
                case "fischen":
                    Console.WriteLine("richtig");
                    break;
                default:
                    Console.WriteLine("entweder hast du dich veschrieben oder die Antwort ist falsch");
                    break;
            }

            //In Java würde bei einem Vergessenen break zwei Werte gelten. In C# wird ein Fehler angezeigt!

        }

        public static void Schleifchen(){
            Console.WriteLine("");
            Console.WriteLine("Schleifchen");

            Console.WriteLine("while-schleife");
            int i = 0;//Initialisierung

            while(i<10)//Bedingung
            {
                i++;//Inkrement
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("for-Schleifen");
            string[] someStrings = 
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };
            
            for (int s = 0; s < 5; s++)
            {
                Console.Write(someStrings[s] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("while-schleife2");
            int w = 0;
            while(w<someStrings.Length){
                Console.Write(someStrings[w] + " ");
                w++;
            }
            Console.WriteLine("");
            Console.WriteLine("do-while");
            
            int i2=0;
            do
            {
                Console.Write(someStrings[i2] + " ");
                i2++;
            }
            while(i2<someStrings.Length);

            Console.WriteLine("");
            Console.WriteLine("while-break");

            int i3 = 0;
            while(true){
                Console.Write(someStrings[i3] + " ");
                if(i3>=someStrings.Length-1)
                    break;
                i3++;
            }       
        }

        static void Main(string[] args)
        {
            Initialisierung();
            Typinferenz();
            Arryas();
            Zeichenkette();
            Anweisungen();
            Auswahl();
            Schleifchen();
        }
    }

}