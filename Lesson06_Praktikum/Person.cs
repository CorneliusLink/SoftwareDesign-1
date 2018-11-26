using System;

namespace Lesson06_Praktikum
{
    class Person
    {
        public string firstName, lastName;
        public int age;
        
        public Person(){}

        public Person(string firstName, string lastName, int age){
            this.firstName = firstName;
            this.age = age;
            this.lastName = lastName;
        }

        public virtual string GetAnrede(){
            return "was geht " + firstName;
        }
    }
}
