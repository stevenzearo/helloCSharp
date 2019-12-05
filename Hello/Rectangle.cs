using System;

namespace ConsoleApp1 {
    class Rectangle {
        private double _width;
        private double _height;

        public void AcceptDetails(double widthVal, double heightVal) {
            _width = widthVal;
            _height = heightVal;
        }

        double GetArea() {
            return _width * _height;
        }

        public void Display() {
            Console.WriteLine("width: {0}", _width);
            Console.WriteLine("height: {0}", _height);
            Console.WriteLine("area: {0}", GetArea());
        }
    }
}