using Aoc2017.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{

    internal class DAction
    {
        public string Variable { get; set; }
        public string Operator { get; set; }
        public int Value { get; set; }

    }

    internal class DCondition
    {
        public string Variable { get; set; }
        public string Operator { get; set; }
        public int Value { get; set; }
    }

    public class Day08 : IDay<int>
    {
        private readonly string _lineSeparator = Environment.NewLine;
        private int _highest;

        public int Part1(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            //Split Into Lines
            var lines = input.Split(new[] { _lineSeparator }, StringSplitOptions.None);


            var rawActionCondition = lines.Select(s => s.Split(new[] { " if " }, StringSplitOptions.None));


            var actionCondition = rawActionCondition.Select(s => new { Action = new DAction() { Operator = s[0].Split(' ')[1], Variable = s[0].Split(' ')[0], Value = int.Parse(s[0].Split(' ')[2]) }, Condition = new DCondition() { Operator = s[1].Split(' ')[1], Variable = s[1].Split(' ')[0], Value = int.Parse(s[1].Split(' ')[2]) } }).ToList();

            var r1 = actionCondition.Select(s => s.Action.Variable).ToList();
            var r2 = actionCondition.Select(s => s.Condition.Variable).ToList();
            var h1 = new HashSet<string>(r1);
            h1.UnionWith(r2);

            //register = r1.Concat(r2).ToDictionary(k => k.Key, v => v.Value);

            var register = h1.ToDictionary(k => k, v => 0);

            //var cOps = actionCondition.Select(s => s.Condition.Operator).Distinct();
            //var aOps = actionCondition.Select(s => s.Action.Operator).Distinct();

            foreach (var ac in actionCondition)
            {
                //Condition
                switch (ac.Condition.Operator)
                {
                    case "<":
                        if (register[ac.Condition.Variable] < ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;

                    case "<=":
                        if (register[ac.Condition.Variable] <= ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;
                    case "==":
                        if (register[ac.Condition.Variable] == ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;
                    case "!=":
                        if (register[ac.Condition.Variable] != ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;
                    case ">=":
                        if (register[ac.Condition.Variable] >= ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;
                    case ">":
                        if (register[ac.Condition.Variable] > ac.Condition.Value)
                        {
                            DoAction(ac.Action, register);
                        }
                        break;
                    default:
                        throw new Exception("Missing Operator");
                }
            }

            return register.Max(m=>m.Value);
        }

        private void DoAction(DAction action, IDictionary<string, int> register)
        {
            switch (action.Operator)
            {
                case "dec":
                    register[action.Variable] -= action.Value;
                    break;
                case "inc":
                    register[action.Variable] += action.Value;
                    break;
                default:
                    throw new Exception("Missing Operator");
            }

            var max = register.Max(m => m.Value);
            if (max > _highest)
                _highest = max;
        }

        public int Part2(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;
            Part1(input);
            return _highest;
        }
    }
}