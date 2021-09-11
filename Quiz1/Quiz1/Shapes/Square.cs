using System;

namespace Quiz1.Shapes
{
    public class Square : Shape
    {
        private readonly double _sideLength = 0;

        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        public override double Area()
        {
            return _sideLength * _sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type = {nameof(Square)}, Area = {Area()}");
        }
    }
}
