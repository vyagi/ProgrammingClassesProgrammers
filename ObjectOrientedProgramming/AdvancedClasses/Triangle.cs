using System;

namespace AdvancedClasses
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override double Area()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        public override string ToString()
        {
            return $"Triangle: {_sideA},{_sideB},{_sideC}";
        }
    }
}
