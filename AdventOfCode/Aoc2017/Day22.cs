using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public enum DirectionEnumType
    {
        Up, Down, Left, Right
    }

    [Flags]
    public enum Day22State
    {
        Initial = 0,
        Clean = 1,
        Infected = 2
    }

    public class Day22Point : Point
    {
        public Day22State State { get; set; } = Day22State.Initial | Day22State.Clean;
        public int Infections { get; set; }
        public Day22Point(Point p) : base(p)
        {
        }

        public Day22Point(int x, int y, Day22State state = Day22State.Initial | Day22State.Clean) : base(x, y)
        {
            State = state;
        }

        public static Day22Point operator +(Day22Point c1, Day22Point c2) =>
            new Day22Point(c1.X + c2.X, c1.Y + c2.Y);
    }


    public class SporificaVirus
    {

        public DirectionEnumType Direction { get; set; } = DirectionEnumType.Up;

        public Day22Point Current { get; set; } = new Day22Point(0, 0);

        public List<Day22Point> Points { get; set; } = new List<Day22Point>();


        public Dictionary<DirectionEnumType, Day22Point> StepSize { get; set; } = new Dictionary<DirectionEnumType, Day22Point>();


        public SporificaVirus(string input, int d)
        {

            StepSize.Add(DirectionEnumType.Up, new Day22Point(-1, 0));
            StepSize.Add(DirectionEnumType.Down, new Day22Point(1, 0));
            StepSize.Add(DirectionEnumType.Left, new Day22Point(0, -1));
            StepSize.Add(DirectionEnumType.Right, new Day22Point(0, 1));

            var x = new List<List<char>>();

            for (var j = 0; j < d; j++)
            {
                x.Add(new List<char>());
                for (var k = 0; k < d; k++)
                {
                    x[j].Add(default);
                }

            }

            var str = input.Replace(Environment.NewLine, string.Empty).ToList();

            for (var k = 0; k < d; k++)
            {
                for (var l = 0; l < d; l++)
                {
                    var index = k * d + l;
                    x[k][l] = str[index];

                    Points.Add(new Day22Point(k, l, str[index] == '.' ? Day22State.Initial | Day22State.Clean : Day22State.Initial | Day22State.Infected));
                }
            }

            Current = Points[Points.Count / 2 + Points.Count % (Points.Count / 2) - 1];
        }

        public int Infected
        {
            get { return Points.Sum(c => c.Infections); }
        }


        public void Burst()
        {
            if (Current.State == Day22State.Infected)
            {
                TurnRight();
            }
            else
            {
                TurnLeft();
            }

            if (Current.State == Day22State.Clean)
            {
                Current.State = Day22State.Infected;
                Current.Infections++;
            }
            else
            {
                Current.State = Day22State.Clean;
            }

            Step();
        }

        private void Step()
        {
            Current = Current + StepSize[Direction];

            var found = Points.FirstOrDefault(f => f.X == Current.X && f.Y == Current.Y);
            if (found == null)
            {
                Points.Add(Current);
            }
            else
            {
                Current = found;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case DirectionEnumType.Up:
                    Direction = DirectionEnumType.Left;
                    break;
                case DirectionEnumType.Down:
                    Direction = DirectionEnumType.Right;
                    break;
                case DirectionEnumType.Left:
                    Direction = DirectionEnumType.Down;
                    break;
                case DirectionEnumType.Right:
                    Direction = DirectionEnumType.Up;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case DirectionEnumType.Up:
                    Direction = DirectionEnumType.Right;
                    break;
                case DirectionEnumType.Down:
                    Direction = DirectionEnumType.Left;
                    break;
                case DirectionEnumType.Left:
                    Direction = DirectionEnumType.Up;
                    break;
                case DirectionEnumType.Right:
                    Direction = DirectionEnumType.Down;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

    public class Day22
    {
        public int Part1(string input, int dimension, int bursts)
        {
            var sot = new SporificaVirus(input, dimension);
            for (var i = 0; i < bursts; i++)
            {
                sot.Burst();
            }
            return sot.Infected;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}