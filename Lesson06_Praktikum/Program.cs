using System;

namespace Lesson06_Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person alde = new Person("Cristoph", "Müller", 50);
            Console.WriteLine(alde.age);
            Mitarbeiter Hans = new Mitarbeiter("Hans" ,"Peter" , 60, 1566415);
            Console.WriteLine(Hans.firstName + " " + alde.age + " " + Hans.iD);
             */
            
            Person [] person = new Person[4];
            person[0] = new Person("Cristoph", "Müller", 50);
            person[1] = new Mitarbeiter("Hans" ,"Peter" , 60, 1566415);
            person[2] = new Frau("Sabrina", "Flitchen", 25, "weiblich");
            person[3] = new Mann("Klaus", "Dieter", 100, "männlich");

            for(int i = 0; i<person.Length; i++){
                Console.WriteLine(person[i].GetAnrede());
                Console.WriteLine(person[i].firstName);
                Console.WriteLine(person[i].lastName);
                Console.WriteLine(person[i].age);
            }
        }
    }
}
