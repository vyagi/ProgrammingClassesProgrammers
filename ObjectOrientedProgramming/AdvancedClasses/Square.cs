namespace AdvancedClasses
{
    public class Square : Shape
    {
        private double _sideLength;
        public Square(double side)
        {
            _sideLength = side;
        }
        public override double Area()
        {
            return _sideLength * _sideLength;
        }
    }
}
