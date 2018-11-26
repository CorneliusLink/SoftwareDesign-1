using System;

namespace Lesson06_Praktikum
{
    class Frau:Person
    {
        public string geschlecht;
        public Frau(){}
        public Frau(string firstName,string lastName, int age, string geschlecht){
            base.firstName = firstName;
            base.lastName = lastName;
            base.age = age;
            this.geschlecht = geschlecht;
        }

        public override string GetAnrede(){
            return "sehr geehrte Frau " + lastName;
        }
    }
}
