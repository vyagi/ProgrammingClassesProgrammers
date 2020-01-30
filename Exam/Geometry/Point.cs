using System;

namespace Geometry
{
    public interface IMoveable
    {
        void Move(double x, double y);
    }
    public class Point : IMoveable
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point()
        {
            _x = _y = 0;
        }
        public Point(double a)
        {
            _x = _y = a;
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void Move(double x, double y)
        {
            _x += x;
            _y += y;
        }
        public virtual double Distance()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }
    }
}
