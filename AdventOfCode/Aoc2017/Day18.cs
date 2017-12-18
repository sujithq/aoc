using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{

    internal class Duet
    {
        public Dictionary<char, long> Register { get; set; }
        public Dictionary<char, long> LastSounds { get; set; }

        public List<string> Instructions { get; set; }

        public int CurrentIndex { get; set; }

        public Duet(List<string> instructions)
        {
            Register = new Dictionary<char, long>();
            LastSounds = new Dictionary<char, long>();
            Instructions = instructions;

            var dist = instructions.Select(s => s.Skip(4).First()).Distinct().ToList();

            Register = dist.ToDictionary(k => k, v => 0L);
            LastSounds = dist.ToDictionary(k => k, v => 0L);
        }

        public long Start()
        {
            while (true)
            {
                var instruction = Instructions[CurrentIndex];
                ProcessInstruction(instruction);
                if (instruction.StartsWith("rcv"))
                {
                    if (LastSounds[instruction.Skip(4).ToList()[0]] != 0)
                        return LastSounds[instruction.Skip(4).ToList()[0]];
                }
                CurrentIndex++;
            }
        }

        public void ProcessInstruction(string instruction)
        {
            var type = instruction.Substring(0, 3);

            switch (type)
            {
                case "set":
                    ProcessSet(instruction.Substring(4));
                    break;
                case "add":
                    ProcessAdd(instruction.Substring(4));
                    break;
                case "mul":
                    ProcessMul(instruction.Substring(4));
                    break;
                case "mod":
                    ProcessMod(instruction.Substring(4));
                    break;
                case "snd":
                    ProcessSnd(instruction.Substring(4));
                    break;
                case "rcv":
                    ProcessRcv(instruction.Substring(4));
                    break;
                case "jgz":
                    ProcessJgz(instruction.Substring(4));
                    break;
            }
        }

        private void ProcessMul(string substring)
        {
            var pars = substring.Split(' ');

            var res = int.TryParse(pars[1], out var val);
            if (res)
            {
                SetValue(pars[0][0], Register[pars[0][0]] * val);
            }
            else
            {
                SetValue(pars[0][0], Register[pars[0][0]] * Register[pars[1][0]]);
            }

        }

        private void ProcessJgz(string substring)
        {
            var pars = substring.Split(' ');
            if (int.TryParse(pars[0], out var val1))
            {
                if (val1 == 0)
                    return;
            }
            else
            {
                if (Register[pars[0][0]] == 0)
                    return;
            }

            var res = int.TryParse(pars[1], out var val);
            if (res)
            {
                if (val != 0)
                    CurrentIndex += val - 1;
            }
            else
            {
                if (Register[pars[1][0]] != 0)
                    CurrentIndex += (int)Register[pars[1][0]] - 1;
            }
        }

        private void ProcessRcv(string substring)
        {
            if (LastSounds[substring[0]] != 0)
            {
                SetValue(substring[0], LastSounds[substring[0]]);
            }
        }

        private void ProcessSnd(string substring)
        {
            if (LastSounds.ContainsKey(substring[0]))
                LastSounds[substring[0]] = Register[substring[0]];
            else
                LastSounds.Add(substring[0], Register[substring[0]]);
        }

        private void ProcessMod(string substring)
        {
            var pars = substring.Split(' ');

            var res = int.TryParse(pars[1], out var val);
            if (res)
            {
                SetValue(pars[0][0], Register[pars[0][0]] % val);
            }
            else
            {
                SetValue(pars[0][0], Register[pars[0][0]] % Register[pars[1][0]]);
            }


        }

        private void ProcessAdd(string substring)
        {
            var pars = substring.Split(' ');

            var res = int.TryParse(pars[1], out var val);
            if (res)
            {
                SetValue(pars[0][0], Register[pars[0][0]] + val);
            }
            else
            {
                SetValue(pars[0][0], Register[pars[0][0]] + Register[pars[1][0]]);
            }
        }

        private void ProcessSet(string substring)
        {
            var pars = substring.Split(' ');


            var res = int.TryParse(pars[1], out var val);
            if (res)
                SetValue(pars[0][0], val);
            else
                SetValue(pars[0][0], Register[pars[1][0]]);
        }

        private void SetValue(char c, long value)
        {
            Register[c] = value;
        }
    }
    public class Day18
    {
        public long Part1(string input)
        {
            var duet = new Duet(input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList());
            return duet.Start();
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}