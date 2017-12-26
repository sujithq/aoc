using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Aoc2017
{
    public class Day24Node
    {
        public string Component { get; set; }
        public string Parent { get; set; }
        public string StartComponent { get; set; }
        public List<string> Parents { get; set; }
        public List<Day24Node> Children { get; set; }
        public int Value { get; set; }

        public Day24Node()
        {
            Parents = new List<string>();
            Children = new List<Day24Node>();
        }
    }

    public class Day24
    {
        private readonly TextWriter _textWriter;

        public List<string> Components { get; set; }
        public List<string> StartComponents { get; set; }
        public int MaxValue { get; set; } = int.MinValue;
        public List<Day24Node> Nodes { get; set; }

        public Dictionary<string, int> Values { get; set; }

        object _sync = new object();

        public Dictionary<string, HashSet<string>> VariantsStartsWith { get; set; }
        public Dictionary<string, HashSet<string>> VariantsEndsWith { get; set; }

        public Day24(string input, TextWriter textWriter)
        {
            _textWriter = textWriter;
            Components = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            VariantsStartsWith = Components.ToDictionary(k => k, v =>
            {
                var x = v.Split('/').Select(s => s + "/").ToList();
                return new HashSet<string>(x);
            });
            VariantsEndsWith = Components.ToDictionary(k => k, v =>
            {
                var x = v.Split('/').Select(s => "/" + s).ToList();
                return new HashSet<string>(x);
            });

            Values = Components.ToDictionary(k => k, v => v.Split('/').Select(int.Parse).Sum());

            StartComponents = Components.Where(w => w.StartsWith("0/")).ToList();

            Components.RemoveAll(p => p.StartsWith("0/"));

            Nodes = StartComponents.Select(s => new Day24Node() { Component = s, StartComponent = s }).ToList();


            Parallel.ForEach(Nodes, ProcessChildren);
        }

        private void ProcessChildren(Day24Node node)
        {
             //Working Components
            var comps = Components.ToList();
            comps.RemoveAll(r => node.Parents.Contains(r));

            var vStart = VariantsStartsWith[node.Component];
            var vEnd = VariantsEndsWith[node.Component];

            var cs = new List<string>();
            foreach (var _v in vStart)
            {
                cs.AddRange(comps.Where(w => w.StartsWith(_v)).ToList());
            }

            foreach (var _v in vEnd)
            {
                cs.AddRange(comps.Where(w => w.EndsWith(_v)).ToList());
            }

            cs = cs.Distinct().ToList();

            if (cs.Any())
            {


                Parallel.ForEach(cs, c =>
                {
                    var n = new Day24Node() { Component = c, Parent = node.Component, StartComponent = node.StartComponent };
                    n.Parents.AddRange(node.Parents);
                    if (!n.Parents.Contains(node.Component))
                        n.Parents.Add(node.Component);

                    ProcessChildren(n);

                    node.Children.Add(n);

                });
            }

            node.Value = node.Parents.Select(s => Values[s]).Sum();

            _textWriter.WriteLine("Processed {0} => {1}", string.Join("--", node.Parents), node.Value);

            lock (_sync)
            {
                if (node.Value > MaxValue)
                {
                    MaxValue = node.Value;
                    _textWriter.WriteLine("New Max {0} => {1}", string.Join("--", node.Parents), node.Value);
                }
            }
        }

        public int Part1()
        {
            return MaxValue;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}