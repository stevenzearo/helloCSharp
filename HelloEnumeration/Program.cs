using System;

namespace HelloEnumeration {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine(System.Enum.GetValues(typeof(Course)));
        }
    }
}