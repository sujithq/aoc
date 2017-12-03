using System;
using System.Collections.Generic;
using System.Linq;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class Day03 : IDay
    {
        private enum ActionTypeEnum
        {
            IncreaseStepSize,
            MoveRight,
            MoveTop,
            MoveLeft,
            MoveBottom
        }

        private readonly List<ActionTypeEnum> _lstActions = new List<ActionTypeEnum>
        {
            ActionTypeEnum.MoveRight,
            ActionTypeEnum.MoveTop,
            ActionTypeEnum.IncreaseStepSize,
            ActionTypeEnum.MoveLeft,
            ActionTypeEnum.MoveBottom,
            ActionTypeEnum.IncreaseStepSize
        };


        public int Part1(string input)
        {
            var res = 0;
            var isInt = int.TryParse(input, out var stop);
            if (input.IsNullOrEmpty() || !isInt)
                return res;

            var currentPoint = new Point(0, 0);
            var stepSize = 1;


            var points = new List<Point> { new Point(currentPoint) };



            if (points.Count == stop)
            {
                return GetSteps(currentPoint);
            }

            while (true)
            {

                foreach (var action in _lstActions)
                {
                    switch (action)
                    {
                        case ActionTypeEnum.IncreaseStepSize:
                            stepSize++;
                            break;
                        case ActionTypeEnum.MoveRight:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new Point(currentPoint);
                                currentPoint.X++;
                                points.Add(new Point(currentPoint));
                                if (points.Count == stop)
                                {
                                    return GetSteps(currentPoint);
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveTop:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new Point(currentPoint);
                                currentPoint.Y++;
                                points.Add(new Point(currentPoint));
                                if (points.Count == stop)
                                {
                                    return GetSteps(currentPoint);
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveLeft:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new Point(currentPoint);
                                currentPoint.X--;
                                points.Add(new Point(currentPoint));
                                if (points.Count == stop)
                                {
                                    return GetSteps(currentPoint);
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveBottom:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new Point(currentPoint);
                                currentPoint.Y--;
                                points.Add(new Point(currentPoint));
                                if (points.Count == stop)
                                {
                                    return GetSteps(currentPoint);
                                }
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        private static int GetSteps(Point currentPoint)
        {
            return Math.Abs(currentPoint.X) + Math.Abs(currentPoint.Y);
        }

        public int Part2(string input)
        {
            var res = 0;
            var isInt = int.TryParse(input, out var stop);
            if (input.IsNullOrEmpty() || !isInt)
                return res;

            var currentPoint = new ValuePoint(0, 0, 1);
            var stepSize = 1;


            var points = new List<ValuePoint> { new ValuePoint(currentPoint) };

            if (points.Last().Value > stop)
            {
                return points.Last().Value;
            }

            while (true)
            {

                foreach (var action in _lstActions)
                {
                    switch (action)
                    {
                        case ActionTypeEnum.IncreaseStepSize:
                            stepSize++;
                            break;
                        case ActionTypeEnum.MoveRight:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new ValuePoint(currentPoint);
                                currentPoint.X++;
                                currentPoint.Value = CalculateValue(points, currentPoint);
                                points.Add(new ValuePoint(currentPoint));
                                if (points.Last().Value > stop)
                                {
                                    return points.Last().Value;
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveTop:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new ValuePoint(currentPoint);
                                currentPoint.Y++;
                                currentPoint.Value = CalculateValue(points, currentPoint);
                                points.Add(new ValuePoint(currentPoint));
                                if (points.Last().Value > stop)
                                {
                                    return points.Last().Value;
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveLeft:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new ValuePoint(currentPoint);
                                currentPoint.X--;
                                currentPoint.Value = CalculateValue(points, currentPoint);
                                points.Add(new ValuePoint(currentPoint));
                                if (points.Last().Value > stop)
                                {
                                    return points.Last().Value;
                                }
                            }
                            break;
                        case ActionTypeEnum.MoveBottom:
                            for (var i = 0; i < stepSize; i++)
                            {
                                currentPoint = new ValuePoint(currentPoint);
                                currentPoint.Y--;
                                currentPoint.Value = CalculateValue(points, currentPoint);
                                points.Add(new ValuePoint(currentPoint));
                                if (points.Last().Value > stop)
                                {
                                    return points.Last().Value;
                                }
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        private static int CalculateValue(IReadOnlyCollection<ValuePoint> points, Point point)
        {
            var lt = points.FirstOrDefault(f => f.X == point.X - 1 && f.Y == point.Y + 1);
            var t = points.FirstOrDefault(f => f.X == point.X && f.Y == point.Y + 1);
            var rt = points.FirstOrDefault(f => f.X == point.X + 1 && f.Y == point.Y + 1);
            var l = points.FirstOrDefault(f => f.X == point.X - 1 && f.Y == point.Y);
            var r = points.FirstOrDefault(f => f.X == point.X + 1 && f.Y == point.Y);
            var lb = points.FirstOrDefault(f => f.X == point.X - 1 && f.Y == point.Y - 1);
            var b = points.FirstOrDefault(f => f.X == point.X && f.Y == point.Y - 1);
            var rb = points.FirstOrDefault(f => f.X == point.X + 1 && f.Y == point.Y - 1);
            var adjacents = new List<ValuePoint>
            {
                lt,t,rt,l,r,lb,b,rb
            };

            return adjacents.Where(w => w != null).Sum(s => s.Value);
        }
    }
}