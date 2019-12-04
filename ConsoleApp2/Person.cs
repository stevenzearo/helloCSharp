using System;

namespace ConsoleApp2 {
    public class Person {
        protected string Name;
        protected int Age;

        protected Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public void Say() {
            Console.WriteLine("{0} says hello to you.", Name);
        }

        public override string ToString() {
            return $"name:{Name}, age:{Age}";
        }
    }
}