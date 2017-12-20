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
        static readonly double Sqrt3 = Math.Pow(3, 0.5);
        static double yStep = Sqrt3 / 2;
        static double xStep = 1.5;

        public Point11(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public int Distance
        {
            get
            {
                var x = X * xStep;
                var y = Y * yStep;

                //calculate crosspoint axis \
                var m = Sqrt3 / 3;

                if (x >= 0 && y >= 0)
                {
                }
                else if (x < 0 && y > 0)
                    m = -m;

                else if (x <= 0 && y <= 0)
                {
                }

                else if (x > 0 && y < 0)
                    m = -m;
                else
                    return 0;

                var cy = m * x;
                var cx = x;

                var dx = Math.Abs(Math.Abs(y) - Math.Abs(cy)) / 2 / yStep;

                var d0 = Math.Sqrt(cx * cx + cy * cy) / 2 / yStep;

                return (int)(dx + d0);
            }
        }

        public int MaxDistance { get; set; }

        public static Point11 operator +(Point11 c1, Point11 c2)
        {
            var p = new Point11(c1.X + c2.X, c1.Y + c2.Y);
            return p;
        }

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

        public override string ToString() => $"({X},{Y})";

    }

    public class Day11 : IDay<int>
    {
        private Dictionary<Movement11Enum, Point11> _movs;


        public int Part1(string input)
        {
            var startPoint = new Point11(0, 0);
            _movs = new Dictionary<Movement11Enum, Point11>()
            {
                {Movement11Enum.n, new Point11(0,2)}
                ,{Movement11Enum.s , new Point11(0,-2)}
                ,{Movement11Enum.ne, new Point11(1,1)}
                ,{Movement11Enum.se, new Point11(1,-1)}
                ,{Movement11Enum.nw, new Point11(-1,1)}
                ,{Movement11Enum.sw, new Point11(-1,-1)}
            };

            if (input.IsNullOrEmpty())
                return int.MinValue;

            startPoint = input.Split(',').Aggregate(startPoint, (current, s) =>
            {
                var c = current + _movs[(Movement11Enum)Enum.Parse(typeof(Movement11Enum), s)];
                c.MaxDistance = c.Distance > current.MaxDistance ? c.Distance : current.MaxDistance;
                return c;
            });

            return startPoint.Distance;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}