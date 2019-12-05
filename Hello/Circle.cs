using System;

namespace ConsoleApp1 {
    public class Circle {
        private readonly int _r;

        public Circle(int r) {
            this._r = r;
        }

        private double GetArea() {
            return _r * _r * Math.PI;
        }

        public override string ToString() {
            return $"r: {_r}, area:{GetArea()}";
        }
    }
}