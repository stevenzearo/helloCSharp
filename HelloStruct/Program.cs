using System;

namespace HelloStruct {
    static class Program {
        static void Main(string[] args) {
            Student student = new Student("steve", 23, 86.7);
            Process(student);
            Console.WriteLine(student);
        }

        static void Process(Student student) {
            student.Age = 22;
        }
    }
}