using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public class Day23
    {

        public Day23(string input, int initialValue = 0)
        {
            Register = Enumerable.Range('a', 8).ToDictionary(Convert.ToChar, v => 0L);
            Register['a'] = initialValue;
            Instructions = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        public List<string> Instructions { get; set; }

        public Dictionary<char, long> Register { get; set; }
        public int CurrentIndex { get; set; }

        public long Muls { get; set; }


        public bool Burst()
        {
            var instruction = Instructions[CurrentIndex];
            ProcessInstruction(instruction);
            CurrentIndex++;
            return CurrentIndex >= 0 && CurrentIndex <= Instructions.Count - 1;
        }


        private void ProcessInstruction(string instruction)
        {
            //var type = instruction.Substring(0, 3);

            //switch (type)
            //{
            //    case "set":
            //        ProcessSet(instruction.Substring(4));
            //        break;
            //    case "sub":
            //        ProcessSub(instruction.Substring(4));
            //        break;
            //    case "mul":
            //        ProcessMul(instruction.Substring(4));
            //        break;
            //    case "mod":
            //        ProcessMod(instruction.Substring(4));
            //        break;
            //    case "jnz":
            //        ProcessJnz(instruction.Substring(4));
            //        break;
            //}

            switch (instruction)
            {
                case "set b 65":
                    SetValue('b', 65);
                    break;
                case "set c b":
                    SetValue('c', Register['b']);
                    break;
                case "set f 1":
                    SetValue('f', 1);
                    break;
                case "set d 2":
                    SetValue('d', 2);
                    break;
                case "set e 2":
                    SetValue('e', 2);
                    break;
                case "set f 0":
                    SetValue('f', 0);
                    break;
                case "set g e":
                    SetValue('g', Register['e']);
                    break;
                case "set g d":
                    SetValue('g', Register['d']);
                    break;
                case "set g b":
                    SetValue('g', Register['b']);
                    break;

                case "mul b 100":
                    SetValue('b', Register['b'] * 100);
                    Muls++;
                    break;

                case "mul g e":
                    SetValue('g', Register['g'] * Register['e']);
                    Muls++;
                    break;

                case "sub b -100000":
                    SetValue('b', Register['b'] + 100000);
                    break;
                case "sub c -17000":
                    SetValue('c', Register['c'] + 17000);
                    break;
                case "sub e -1":
                    SetValue('e', Register['e'] + 1);
                    break;
                case "sub d -1":
                    SetValue('d', Register['d'] + 1);
                    break;
                case "sub g b":
                    SetValue('g', Register['g'] - Register['b']);
                    break;
                case "sub h -1":
                    SetValue('h', Register['h'] - -1);
                    break;
                case "sub g c":
                    SetValue('g', Register['g'] - Register['c']);
                    break;
                case "sub b -17":
                    SetValue('b', Register['b'] + 17);
                    break;

                case "jnz a 2":
                    if (Register['a'] != 0)
                    {
                        CurrentIndex += 1;
                    }
                    break;
                case "jnz 1 5":
                    CurrentIndex += 4;
                    break;
                case "jnz g -8":
                    if (Register['g'] != 0)
                    {
                        CurrentIndex -= 9;
                    }
                    break;
                case "jnz g -13":
                    if (Register['g'] != 0)
                    {
                        CurrentIndex -= 14;
                    }
                    break;
                case "jnz f 2":
                    if (Register['f'] != 0)
                    {
                        CurrentIndex += 1;
                    }
                    break;
                case "jnz g 2":
                    if (Register['g'] != 0)
                    {
                        CurrentIndex += 1;
                    }
                    break;
                case "jnz 1 3":
                    CurrentIndex += 2;
                    break;
                case "jnz 1 -23":
                    CurrentIndex -= 24;
                    break;
                default:
                    throw new Exception("Unknown Instruction");
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

            Muls++;

        }

        private void ProcessJnz(string substring)
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

        private void ProcessSub(string substring)
        {
            var pars = substring.Split(' ');

            var res = int.TryParse(pars[1], out var val);
            if (res)
            {
                SetValue(pars[0][0], Register[pars[0][0]] - val);
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

        public int Part1(string input)
        {
            return int.MinValue;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}