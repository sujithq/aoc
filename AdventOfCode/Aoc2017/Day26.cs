using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public partial class Day26 : IDay<int>
    {
        public class Robot
        {
            public Robot()
            {
                Movements = new List<Point>();
                NextSteps = new List<Point>();
            }
            public Point Start { get; set; }

            public List<Point> Movements { get; set; }
            public List<Point> NextSteps { get; set; }

        }

        public int Part1(string input)
        {
            var res = 0;
            if (input.IsNullOrEmpty())
                return res;
            //Split

            var data = input.Split(new[] { "](" }, StringSplitOptions.None);

            //Fix Data
            data[0] += "]";
            data[1] = "(" + data[1];

            //Split Robots

            var startPoints = ParsePoints("[", "]", data[0]);
            var movements = ParsePoints("(", ")", data[1]);


            var robots = new List<Robot>();

            foreach (var startPoint in startPoints)
            {
                robots.Add(new Robot() { Start = startPoint });
            }
            for (var i = 0; i < startPoints.Count; i++)
            {
                for (var j = i; j < movements.Count; j += startPoints.Count)
                {
                    robots[i].Movements.Add(movements[j]);

                }
            }

            var collision = 0;
            foreach (var robot in robots)
            {
                robot.NextSteps.Add(robot.Start);
            }
            for (int i = 0; i < robots.First().Movements.Count; i++)
            {
                foreach (var robot in robots)
                {
                    robot.NextSteps.Add(robot.NextSteps[i]+robot.Movements[i]);
                }

                var lst = robots.Select(s => s.NextSteps.Last()).ToList();

                var kk = new Combinations<Point>(lst,2).ToList().Select(s => new { Key = string.Join("", s.Select(r => r.ToString())), Equal = s.First().ToString() == s.Last().ToString() });


                //var k = MathHelper.GetKCombs(lst, 2).Select(s=>new {Key = string.Join("", s.Select(r=>r.ToString())), Equal = s.First().ToString() == s.Last().ToString()});
                // if (!k.Any())
                //     collision++;
                // else
                // {
                //     if(k.Any(a=>a.Equal))
                //         Console.WriteLine();
                //     collision += k.Count(c => c.Equal);
                // }

                collision += kk.Count(c => c.Equal);
            }
            

            return collision;
        }

        private List<Point> ParsePoints(string s, string s1, string s2)
        {
            var workingRs = s2.Split(new string[] { s1 + s }, StringSplitOptions.None);

            var fix1Rs = new List<string>();
            foreach (var r in workingRs)
            {
                fix1Rs.Add(r.Replace(s, string.Empty));
            }
            var fix2Rs = new List<string>();
            foreach (var r in fix1Rs)
            {
                fix2Rs.Add(r.Replace(s1, string.Empty));
            }

            var points = new List<Point>();

            foreach (var fix2R in fix2Rs)
            {
                var spl = fix2R.Split(',');
                int.TryParse(spl[0], out var x);
                int.TryParse(spl[1], out var y);
                points.Add(new Point(x, y));
            }
            return points;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}