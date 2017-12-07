using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;
using Aoc2017.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Aoc2017
{

    internal class Node
    {
        public string Name { get; set; }
        public string Parent { get; set; }
        public List<string> Children { get; set; }
        public int Weight { get; set; }
        public int Sum { get; set; }

        public Node()
        {
            Children = new List<string>();
        }
    }

    internal class Node2
    {
        public string Name { get; set; }
        //public Node2 Parent { get; set; }
        public List<Node2> Children { get; set; }
        public int Weight { get; set; }
        public int Sum { get; set; }

        public Node2()
        {
            Children = new List<Node2>();
        }
    }

    public class Day07 : IDay<string>
    {
        private readonly string _lineSeparator = Environment.NewLine;
        public string Part1(string input)
        {
            var res = 0;

            if (input.IsNullOrEmpty())
                return string.Empty;

            //Split Into Lines
            var lines = input.Split(new[] { _lineSeparator }, StringSplitOptions.None);

            var lst = new List<Node>();



            foreach (var line in lines)
            {

                var subLines = line.Split(new[] { " -> " }, StringSplitOptions.None);

                subLines[0] = subLines[0].Split(' ').First();

                var n = new Node()
                {
                    Name = subLines[0],
                };

                if (subLines.Length == 2)
                    n.Children = subLines[1].Split(new[] { ", " }, StringSplitOptions.None).ToList();
                lst.Add(n);


            }


            foreach (var node in lst)
            {
                var x = lst.Where(w => w.Children.Count > 0 && w.Name != node.Name).FirstOrDefault(f => f.Children.Contains(node.Name));
                if (x == null)
                    return node.Name;
            }

            return lst.Single(f => f.Parent == null).Name;
        }

        public string Part2(string input)
        {

            var res = 0;

            if (input.IsNullOrEmpty())
                return string.Empty;




            //Split Into Lines
            var lines = input.Split(new[] { _lineSeparator }, StringSplitOptions.None);

            var lst = new List<Node>();



            foreach (var line in lines)
            {

                var subLines = line.Split(new[] { " -> " }, StringSplitOptions.None);

                var n = new Node()
                {
                    Name = subLines[0].Split(' ').First(),
                    Weight = int.Parse(subLines[0].Split(' ').Last().Replace("(", String.Empty).Replace(")", String.Empty))
                };

                if (subLines.Length == 2)
                    n.Children = subLines[1].Split(new[] { ", " }, StringSplitOptions.None).ToList();
                lst.Add(n);


            }


            foreach (var node in lst)
            {
                var x = lst.Where(w => w.Children.Count > 0 && w.Name != node.Name).FirstOrDefault(f => f.Children.Contains(node.Name));
                if (x != null)
                    node.Parent = x.Name;
            }

            var bottomProg = Part1(input);


            var StartNodes = new List<string>() { bottomProg };

            while (true)
            {
                var nextStartNodes = new List<string>();
                foreach (var startNode in StartNodes)
                {
                    var root = lst.Single(s => s.Name == startNode);

                    nextStartNodes.AddRange(root.Children);

                    var childs = new Dictionary<string, int>();
                    //Calculate ChildValues
                    foreach (var singleChild in root.Children)
                    {
                        childs.Add(singleChild, lst.Single(s => s.Name == singleChild).Weight);
                    }

                    foreach (var singleChild in root.Children)
                    {
                        var single = lst.Single(s => s.Name == singleChild);
                        childs[singleChild] += lst.Where(w => single.Children.Contains(w.Name)).Sum(s => s.Weight);
                    }

                    root.Sum = root.Weight + childs.Sum(s => s.Value);

                }

                if (nextStartNodes.Count == 0)
                    break;
                else
                {
                    StartNodes = nextStartNodes.ToList();
                }
            }

            var startNode2 = lst.Single(s => s.Name == bottomProg);
            var start2 = new List<Node2>() { new Node2() { Name = startNode2.Name, Weight = startNode2.Weight, Sum = startNode2.Sum } };

            StartNodes = new List<string>() { bottomProg };

            while (true)
            {
                var nextStartNodes = new List<string>();
                foreach (var startNode in StartNodes)
                {
                    var root = lst.Single(s => s.Name == startNode);

                    var strt = start2.Recursive(p => p.Children, p => p.Name == startNode).First();
                    strt.Children = lst.Where(w => root.Children.Contains(w.Name)).ToList().Select(s => new Node2() { Name = s.Name, Weight = s.Weight, Sum = s.Sum }).ToList();
                    nextStartNodes.AddRange(root.Children);
                }

                if (nextStartNodes.Count == 0)
                    break;
                else
                {
                    StartNodes = nextStartNodes.ToList();
                }
            }

            var json = JsonConvert.SerializeObject(start2.First(), new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });


            var noEdges = lst.Where(w => w.Children.Count > 0).ToList();
            var gNoEdges = noEdges.GroupBy(g => g.Parent);

            foreach (var gNoEdge in gNoEdges)
            {
                var x = gNoEdge.GroupBy(g => g.Sum).Where(w => w.Count() == 1);
                if (x.Any())
                    Console.WriteLine();
            }
            return lst.Single(f => f.Parent == null).Name;
        }

        private static Dictionary<string, int> GetCorrections(List<Node> lst)
        {
            var corrections = new Dictionary<string, int>();
            foreach (var node in lst.Where(w => w.Parent != null))
            {
                //Find parent
                var parent = node.Parent;

                //Find parent Node
                var parentNode = lst.Single(s => s.Name == parent);
                //Find parent parent
                var parentParent = parentNode.Parent;

                if (parentParent != null)
                {
                    //Find parent parent Node
                    var parentParentNode = lst.Single(s => s.Name == parentParent);

                    var checkSum = new Dictionary<string, int>();

                    foreach (var parentParentNodeChild in parentParentNode.Children)
                    {
                        var n = lst.First(f => f.Name == parentParentNodeChild);

                        var check = new List<int>();
                        check.Add(n.Weight);

                        foreach (var nChild in n.Children)
                        {
                            var nn = lst.First(f => f.Name == nChild);
                            check.Add(nn.Weight);
                        }
                        checkSum.Add(parentParentNodeChild, check.Sum());
                    }
                    var groups = checkSum.GroupBy(g => g.Value).ToList();
                    if (groups.Count() > 1)
                    {
                        var keys = groups.Select(s => s.Key).ToList();

                        var min = Math.Min(keys[0], keys[1]);
                        var max = Math.Max(keys[0], keys[1]);
                        var diff = max - min;
                        var g = groups.First(f => f.Count() == 1);


                        var x = lst.First(ff => ff.Name == groups.Find(f => f.Key == g.Key).First().Key);

                        if (g.Key == min)
                        {
                            if (!corrections.ContainsKey(x.Name))
                            {
                                corrections.Add(x.Name, x.Weight + diff);
                                Debug.Print("Name:{0}({1}, ({2}))", x.Name, x.Weight, x.Weight + diff);
                            }
                        }
                        else
                        {
                            if (!corrections.ContainsKey(x.Name))
                            {
                                corrections.Add(x.Name, x.Weight - diff);
                                Debug.Print("Name:{0}({1}, ({2}))", x.Name, x.Weight, x.Weight - diff);
                            }
                        }
                    }
                }

            }
            return corrections;
        }
    }
}