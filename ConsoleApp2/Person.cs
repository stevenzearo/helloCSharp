using System;

namespace ConsoleApp2 {
    public class Person {
        private string _name;
        private int _age;

        public Person(string name, int age) {
            _name = name;
            _age = age;
        }

        public void Say() {
            Console.WriteLine("{0} says hello to you.", _name);
        }

        public override string ToString() {
            return $"name:{_name}, age:{_age}";
        }
    }
}