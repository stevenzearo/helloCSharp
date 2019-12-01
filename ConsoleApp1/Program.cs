using System;

namespace ConsoleApp1 {
    class Program {
        const int a = 0;
        private static int b = a;
        static void Main() {
            Rectangle r = new Rectangle();
            r.AcceptDetails(3.23, 4.25);
            r.Display();
            string s2 = @"<script \ \\ \ntype=""";
            Console.WriteLine(s2);
            const double d = 2E2;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}