using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("i: {0}", i);
            }

            Console.WriteLine("-------------------");
            int[] a = {1, 2, 3, 4, 5};
            foreach (var value in a) {
                Console.WriteLine("value: {0}", value);
            }
        }
    }
}