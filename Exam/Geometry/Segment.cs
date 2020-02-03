using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Segment : IMoveable
    {
        protected Point _start;
        protected Point _end;
        public Segment(Point start, Point end)
        {
            _start = start;
            _end = end;
        }
        public virtual double Length =>
            Math.Sqrt(Math.Pow(_start.X - _end.X, 2) + Math.Pow(_start.Y - _end.Y, 2));

        public virtual void Move(double x, double y)
        {
            _start.Move(x, y);
            _end.Move(x, y);
        }
    }
    public class PolygonalChain : Segment, IMoveable
    {
        private List<Point> _midpoints;
        public PolygonalChain(Point start, Point end)
            : base(start, end) => 
            _midpoints = new List<Point>();
        public void AddMidpoint(Point point) => 
            _midpoints.Add(point);
        public override double Length
        {
            get
            {
                var temp = CreateListOfAllPoints();

                var sumOfLength = 0.0;
                for (int i = 0; i < temp.Count - 1; i++)
                    sumOfLength += new Segment(temp[i], temp[i + 1]).Length;
                
                return sumOfLength;
            }
        }
        public override void Move(double x, double y)
        {
            base.Move(x, y);
            foreach (var midpoint in _midpoints)
                midpoint.Move(x,y);
        }
        public override string ToString() =>
            string.Join(", ", CreateListOfAllPoints());
        private List<Point> CreateListOfAllPoints()
        {
            var temp = new List<Point>();
            temp.Add(_start);
            temp.AddRange(_midpoints);
            temp.Add(_end);
            return temp;
        }
    }
}
