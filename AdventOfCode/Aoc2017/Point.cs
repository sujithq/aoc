using System;

namespace Aoc2017
{

    public class ValuePoint : Point, IComparable<Point>
    {
        public int Value { get; set; }  
        public ValuePoint(ValuePoint p):base(p)
        {
            Value = p.Value;
        }

        public ValuePoint(int x, int y, int value):base(x,y)
        {
            Value = value;
        }

        public override string ToString() => $"{this.Value}({this.X},{this.Y})";

    }
    public class Point : IComparable<Point>
    {
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point c1, Point c2) =>
            new Point(c1.X + c2.X, c1.Y + c2.Y);

        public int CompareTo(Point other)
        {
            if (X == other.X && Y == other.Y) return 0;
            if (X == other.X)
            {
                if (Y > other.Y) return 1;
                return -1;
            }
            if (Y == other.Y)
            {
                if (X > other.X) return 1;
                return -1;
            }
            if (X > other.X)
                return 1;
            if (X < other.X)
                return -1;

            if (Y > other.Y)
                return 1;
            //if (Y < other.Y)
            return -1;
        }

        public override string ToString() => $"({this.X},{this.Y})";

    }
}