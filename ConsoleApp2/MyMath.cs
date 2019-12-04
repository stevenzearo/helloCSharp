using System;
using System.Diagnostics;

namespace ConsoleApp2 {
    public static class MyMath {
        public delegate T Merge<T>(T a, T b);

        public static readonly Merge<double> Power = _Power;
        
        private static double _Power(double a, double b) {
            return Math.Pow(a, b);
        }

        public static T Process<T>(T a, T b, Merge<T> merge) {
            return merge(a, b);
        }
    }
}