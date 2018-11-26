using System;

namespace Lesson06_Praktikum
{
    class Mann:Person
    {
        public string geschlecht;
        public Mann(){}
        public Mann(string firstName,string lastName, int age, string geschlecht){
            base.firstName = firstName;
            base.lastName = lastName;
            base.age = age;
            this.geschlecht = geschlecht;
        }

        public override string GetAnrede(){
            return "sehr geehrter Herr " + lastName;
        }
    }
}
