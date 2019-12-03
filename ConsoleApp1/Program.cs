using System;

namespace ConsoleApp1 {
    class Program {
        private const int A = 0;
        private static int _b = A;
        static void Main() {
            Rectangle r = new Rectangle();
            r.AcceptDetails(3.23, 4.25);
            r.Display();
            string s2 = @"<script \ \\ \ntype=""";
            Console.WriteLine(s2);
            const double d = 2E2;
            Console.WriteLine(d);
            Circle circle = new Circle(1);
            Console.WriteLine(circle ?? new Circle(3));
        }
    }
}