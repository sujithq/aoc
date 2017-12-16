using Aoc2017.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoc2017
{

    internal class Layer
    {

        public Layer(int index, int maxPosition)
        {
            Index = index;
            Position = -1;
            StepSize = 1;
            MaxPosition = maxPosition;
        }

        public override string ToString()
        {
            var val = (Position > -1 ? Position.ToString() : "|");
            return $"{val}";
        }

        public int Index { get; set; }
        public int Position { get; set; }
        public int MaxPosition { get; set; }
        public int StepSize { get; set; }
        public bool Started { get; set; }

        private void Switch()
        {
            StepSize *= -1;
        }

        public void Step()
        {
            if (Index > -1)
                if (Position > -1)
                {
                    if (Position == 0 || Position == MaxPosition && Started)
                    {
                        if (StepSize > 0)
                        {
                            if (Position == MaxPosition)
                            {
                                Switch();
                            }
                        }
                        else
                        {
                            if (Position == 0)
                            {
                                Switch();
                            }
                        }
                    }
                    Position += StepSize;
                    Started = true;
                }
        }
    }


    public class Day13 : IDay<int>
    {
        public int Part1(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            var i = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var ii = i.Select(s =>
            {
                var ss = s.Split(new[] { ": " }, StringSplitOptions.None).ToList();
                return new Layer(int.Parse(ss[0]), int.Parse(ss[1]) - 1);
            }).ToList();

            var iii = new List<Layer>();
            for (var j = 0; j < ii.Last().Index + 1; j++)
            {
                iii.Add(new Layer(0, 0));
            }

            foreach (var layer in ii)
            {
                iii[layer.Index].Index = layer.Index;
                iii[layer.Index].MaxPosition = layer.MaxPosition;
                iii[layer.Index].Position = 0;
            }


            var caught = new List<int>();
            for (var j = 0; j < iii.Count; j++)
            {
                if (iii[j].Position == 0)
                    caught.Add(j);

                foreach (var layer in iii)
                {
                    layer.Step();
                }

            }

            return caught.Sum(s => s * (iii[s].MaxPosition + 1));

        }

        public int Part2(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            var i = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var ii = i.Select(s =>
            {
                var ss = s.Split(new[] { ": " }, StringSplitOptions.None).ToList();
                return new Layer(int.Parse(ss[0]), int.Parse(ss[1]) - 1);
            }).ToList();

            var iii = new List<Layer>();

            Parallel.ForEach(Enumerable.Range(0, ii.Last().Index + 1), f => iii.Add(new Layer(-1, -1)));

            Parallel.ForEach(ii, layer =>
            {
                iii[layer.Index].Index = layer.Index;
                iii[layer.Index].MaxPosition = layer.MaxPosition;
                iii[layer.Index].Position = 0;
            });

            var delay = 0;

            while (true)
            {
                if (delay > 0)
                {
                    //Reset
                    Parallel.ForEach(iii, l =>
                    {
                        if (l.Index > -1) l.Position = 0;
                    });

                    for (var j = 0; j < delay; j++)
                        Parallel.ForEach(iii, l => l.Step());
                }

                foreach (var l1 in iii)
                {
                    if (l1.Position == 0)
                        break;
                    Parallel.ForEach(iii, l => l.Step());
                }

                if (iii.All(a => a.Position != 0))
                    return delay;

                delay++;
            }
        }
    }
}