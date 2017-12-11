using Aoc2017.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Aoc2017
{
    public class Day10
    {
        public int Part1(string input, int size)
        {
            Debug.Print("original input:{0} with size {1}", input, size);
            if (input.IsNullOrEmpty())
                return int.MinValue;
            var skipSize = 0;

            var ll = new LinkedList<int>(Enumerable.Range(0, size));

            Debug.Print("values {0}", string.Join("|", ll));
            var lint = input.Split(new[] { "," }, StringSplitOptions.None).Select(int.Parse).ToList();


            var skip = 0;
            var pos = 0;
            var prev = 0;

            foreach (var item in lint)
            {
                var currentValue = ll.ToList()[prev];
                var currentNode = ll.FindLast(currentValue);

                var lst = new List<int>();
                for (int i = 0; i < item; i++)
                {
                    lst.Add(currentNode.Value);
                    currentNode = currentNode.Next ?? ll.First;
                }
                lst.Reverse();
                for (int i = 0; i < size - item; i++)
                {
                    lst.Add(currentNode.Value);
                    currentNode = currentNode.Next ?? ll.First;
                }

                var newList = new List<int>();

                if (pos == 0)
                {
                    newList.AddRange(lst);
                }
                else
                {
                    newList.AddRange(lst.Skip(size - pos));
                    newList.AddRange(lst.Take(size - newList.Count));
                }


                if (item != lint.Last())
                {
                    //currentNode = ll.FindLast(currentValue);
                    prev = pos;
                    pos += item + skip++;
                    pos = pos % size;

                    ll = new LinkedList<int>(newList);
                }
                else
                {
                    return newList[0] * newList[1];
                    Console.WriteLine();  
                }

            }

            //var c = ll.First;
            //var currtPos = 0;
            //var lstPos = new List<int>(){currtPos};
            //foreach (var i in lint)
            //{
            //    Debug.Print("Starting List:{0}",string.Join("|", ll));
            //    var subList = ll.Take(i).ToList();
            //    Debug.Print("SubList:{0}", string.Join("|", subList));
            //    subList.Reverse();
            //    Debug.Print("Reversed SubList:{0}", string.Join("|", subList));
            //    subList.AddRange(ll.Skip(i));
            //    Debug.Print("New Staring List:{0}", string.Join("|", subList));
            //    currtPos += i + skipSize++;
            //    currtPos = currtPos % size;
            //    lstPos.Add(currtPos);
            //    Debug.Print("Pos: {0}", currtPos);
            //    ll = new LinkedList<int>(subList);
            //    DisplayFirstTwoItems(ll, lstPos);

            //}

            //Debug.Print("Possitions List:{0}", string.Join("|", lstPos));

            //return DisplayFirstTwoItems(ll, lstPos);

            //var curPos = 0;
            //foreach (var i in lint)
            //{

            //    Debug.Print("-------------");
            //    Debug.Print("start value {0}", string.Join("|", ll.Select(s => s)));
            //    Debug.Print("value {0}", i);
            //    Debug.Print("skip {0}", skipSize);

            //    //prepare list
            //    var l = new List<int> { c.Value };
            //    for (int j = 1; j < i; j++)
            //    {
            //        c = c.Next ?? ll.First;
            //        l.Add(c.Value);
            //    }
            //    //reverse
            //    l.Reverse();

            //    Debug.Print("partial reversed {0}", string.Join("|", l));

            //    //add missing items
            //    for (; l.Count < size;)
            //    {
            //        c = c.Next ?? ll.First;
            //        l.Add(c.Value);
            //    }

            //    Debug.Print("full reversed {0}", string.Join("|", l));

            //    //move cursor
            //    var currentPos = i + skipSize;
            //    curPos += i + skipSize;
            //    curPos = curPos % size;
            //    Debug.Print("position {0}",currentPos);
            //    ll = new LinkedList<int>(l);
            //    c = ll.First;
            //    for (int j = 0; j < currentPos; j++)
            //    {
            //        c = c.Next ?? ll.First;
            //    }
            //    skipSize++;
            //    Debug.Print("current value {0}", c.Value);
            //    if (i == lint.Last())
            //    {
            //        c = c.Next ?? ll.First;
            //        Debug.Print("Factor 1{0}", c.Value);
            //        var res = c.Value;
            //        c = c.Next ?? ll.First;
            //        Debug.Print("Factor 2{0}", c.Value);
            //        res *= c.Value;

            //        return res;

            //    }
            //}



            return int.MinValue;
        }

        private static int DisplayFirstTwoItems(LinkedList<int> ll, List<int> lstPos)
        {
            var lastVal = ll.ToList()[lstPos.Last()];
            var first = ll.Find(lastVal);
            var next = first.Next ?? ll.First;
            Debug.Print("First 2 items: ({0}, {1})", first.Value, next.Value);
            return first.Value * next.Value;
        }

        public int Part2(string input, int size)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;
            return int.MinValue;
        }
    }
}