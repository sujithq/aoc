using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoc2017
{
    public class Point20
    {
        public long X { get; }
        public long Y { get; }
        public long Z { get; }

        public static Point20 operator +(Point20 c1, Point20 c2)
        {
            var p = new Point20(c1.X + c2.X, c1.Y + c2.Y, c1.Z + c2.Z);
            return p;
        }

        public Point20(long x, long y, long z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point20(string input)
        {
            var i = input.Split(',').Select(int.Parse).ToList();
            X = i[0];
            Y = i[1];
            Z = i[2];
        }
    }

    public class Particle : IComparable<Particle>
    {
        public Point20 P { get; set; }
        public Point20 V { get; set; }
        public Point20 A { get; }
        public int Index { get; }
        public long MinManDistance { get; private set; } = long.MaxValue;

        public long ManDistance => Math.Abs(P.X) + Math.Abs(P.Y) + Math.Abs(P.Y);

        public Particle(Point20 p, Point20 v, Point20 a, int index)
        {
            P = p;
            V = v;
            A = a;
            Index = index;
        }

        public void Tick()
        {
            V += A;
            P += V;

            if (ManDistance < MinManDistance)
                MinManDistance = ManDistance;
        }

        public int CompareTo(Particle other)
        {
            //return MinManDistance == other.MinManDistance ? 0 : MinManDistance > other.MinManDistance ? 1 : -1;
            return ManDistance == other.ManDistance ? 0 : ManDistance > other.ManDistance ? 1 : -1;
        }
    }
    public class Day20
    {
        public List<Particle> Part1(string input)
        {
            var ps = new List<Particle>();

            foreach (var inp in input.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                var i = inp.Split(new[] { ", " }, StringSplitOptions.None);

                var ii = i.Select(s => s.Split('=')).ToList();

                foreach (var _ii in ii)
                {
                    _ii[1] = _ii[1].Replace("<", string.Empty).Replace("<", string.Empty).Replace(">", string.Empty);
                }

                var iii = ii.ToDictionary(k => k[0], v => new Point20(v[1]));

                var part = new Particle(iii["p"], iii["v"], iii["a"], ps.Count);

                ps.Add(part);
            }

            return ps;
        }

        public int Part2(string input, int count)
        {
            return int.MinValue;
        }
    }
}