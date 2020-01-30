using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Segment
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
    }

    public class PolygonalChain : Segment
    {
        private List<Point> _midpoints;
        public PolygonalChain(Point start, Point end) 
            : base(start, end)
        {
            _midpoints = new List<Point>();
        }
        public void AddMidpoint(Point point)
        {
            _midpoints.Add(point);
        }
        public override double Length
        {
            get
            {
                var temp = new List<Point>();
                temp.Add(_start);
                temp.AddRange(_midpoints);
                temp.Add(_end);

                var sumOfLength = 0.0;
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    sumOfLength += new Segment(temp[i], temp[i+1]).Length;
                }
                return sumOfLength;
            }
        };
    }
}
