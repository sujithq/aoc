using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public class Day19
    {
        public Day19(string input)
        {
            StepSize.Add(DirectionEnumType.Up, new Day22Point(-1, 0));
            StepSize.Add(DirectionEnumType.Down, new Day22Point(1, 0));
            StepSize.Add(DirectionEnumType.Left, new Day22Point(0, -1));
            StepSize.Add(DirectionEnumType.Right, new Day22Point(0, 1));

            var splitted = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            var maxLine = splitted.Max(m => m.Length);

            var d = Math.Max(maxLine, splitted.Count);

            for (var i = 0; i < splitted.Count; i++)
            {
                splitted[i] = splitted[i].PadRight(d);
            }

            if (splitted.Count < d)
            {
                var count = d - splitted.Count;
                for (var i = 0; i < count; i++)
                {
                    splitted.Add(string.Empty.PadRight(d));
                }
            }

            Grid = To2D(string.Join("", splitted).AsSpan(), d).ToList();

            Current = new Point(0, Grid[0].FindIndex(f => f == '|'));
            Pointer = Grid[Current.X][Current.Y];
            Steps = 1;
        }

        private Dictionary<DirectionEnumType, Point> StepSize { get; } = new Dictionary<DirectionEnumType, Point>();

        private Point Current { get; set; }

        private DirectionEnumType Direction { get; set; } = DirectionEnumType.Down;

        private List<char> Letters = new List<char>();
        private int Steps { get; set; }

        public string Part1()
        {


            Process();

            return string.Join("", Letters);
        }

        private void Process()
        {
            var exit = false;
            while (!exit)
            {
                Current = Current + StepSize[Direction];
                Pointer = Grid[Current.X][Current.Y];
                Steps++;

                switch (Pointer)
                {
                    case '|':
                    case '-':
                        break;
                    case '+':
                        switch (Direction)
                        {
                            case DirectionEnumType.Up:
                            case DirectionEnumType.Down:
                                var left = Current + StepSize[DirectionEnumType.Left];
                                Direction = char.IsWhiteSpace(Grid[left.X][left.Y]) ? DirectionEnumType.Right : DirectionEnumType.Left;
                                break;
                            case DirectionEnumType.Left:
                            case DirectionEnumType.Right:
                                var up = Current + StepSize[DirectionEnumType.Up];
                                Direction = char.IsWhiteSpace(Grid[up.X][up.Y]) ? DirectionEnumType.Down : DirectionEnumType.Up;
                                break;
                        }
                        break;
                    default:
                        if (char.IsLetter(Pointer))
                        {
                            Letters.Add(Pointer);
                        }
                        else
                        {
                            exit = true;
                            Steps--;
                        }
                        break;
                }
            }
        }

        public char Pointer { get; set; }

        public List<List<char>> Grid { get; set; }

        private static IEnumerable<List<char>> To2D(ReadOnlySpan<char> str, int d)
        {
            var x = new List<List<char>>();
            for (var j = 0; j < d; j++)
            {
                x.Add(new List<char>());
                for (var k = 0; k < d; k++)
                {
                    x[j].Add(default);
                }
            }

            for (var k = 0; k < d; k++)
            {
                for (var l = 0; l < d; l++)
                {
                    var index = k * d + l;
                    x[k][l] = str[index];
                }
            }
            return x;
        }



        public int Part2()
        {
            Process();
            return Steps;
        }
    }
}