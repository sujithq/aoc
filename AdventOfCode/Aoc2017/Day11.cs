using Aoc2017.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    internal enum Movement11Enum
    {
        n, ne, se, s, sw, nw
    }

    internal class Point11 : IComparable<Point11>
    {
        public Point11(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public Point11(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public static Point11 operator +(Point11 c1, Point11 c2) =>
            new Point11(c1.X + c2.X, c1.Y + c2.Y);

        public int CompareTo(Point11 other)
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

    public class Day11 : IDay<int>
    {
        private Dictionary<Movement11Enum, Point11> movs;


        public int Part1(string input)
        {
            Point11 startPoint = new Point11(0, 0);
            var sqrt3 = (double)Math.Pow(3, 0.5);
            var height = sqrt3;
            movs = new Dictionary<Movement11Enum, Point11>()
            {
                {Movement11Enum.n, new Point11(2*height,0)}
                ,{Movement11Enum.s , new Point11(-2*height,0)}
                ,{Movement11Enum.ne, new Point11(1.5*height,height)}
                ,{Movement11Enum.se, new Point11(1.5*height,-height)}
                ,{Movement11Enum.nw, new Point11(-1.5*height,height)}
                ,{Movement11Enum.sw, new Point11(-1.5*height,-height)}
            };

            if (input.IsNullOrEmpty())
                return int.MinValue;

            startPoint = input.Split(',').Aggregate(startPoint, (current, s) => current + movs[(Movement11Enum)Enum.Parse(typeof(Movement11Enum), s)]);

            //calculate crosspoint axis \
            var m = 2 * sqrt3 / 3;
            var cx = startPoint.Y + m * startPoint.X / 2 / m;
            var cy = startPoint.Y + m * startPoint.X;

            var d0 = Math.Pow(cx * cx + cy * cy, 0.5);

            var dc = Math.Pow(Math.Pow(startPoint.X - cx,2) + Math.Pow(startPoint.Y - cy, 2), 0.5); ;


            var steps = 0;
            return (int)steps;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}