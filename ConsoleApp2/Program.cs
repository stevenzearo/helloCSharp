using System;

namespace ConsoleApp2 {
    static class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("i: {0}", i);
            }

            Console.WriteLine("-------------------");
            int[] a = {1, 2, 3, 4, 5};
            foreach (int value in a) {
                Console.WriteLine("value: {0}", value);
            }

            Student student = new Student("steve", 23, 87.6);
            Console.WriteLine(student);

            int result = MyMath.Process(1, 3, (val1, val2) => val1 + val2);
            double result2 = MyMath.Process(3, 2, MyMath.Power);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}