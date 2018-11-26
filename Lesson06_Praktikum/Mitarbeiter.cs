using System;

namespace Lesson06_Praktikum
{
    class Mitarbeiter:Person
    {
        public int iD;

        public Mitarbeiter(){}
        public Mitarbeiter(string firstName,string lastName, int age, int iD){
            base.firstName = firstName;
            base.lastName = lastName;
            base.age = age;
            this.iD = iD;
        }

        public override string GetAnrede(){
            return "alles klar " + firstName + " du Bauer";
        }
    }
}
