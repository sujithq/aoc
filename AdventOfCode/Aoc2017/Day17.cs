using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Interfaces;

namespace Aoc2017
{

    internal class SpinLock
    {
        public LinkedList<int> InternalList { get; set; }
        public int Position { get; set; }
        public int Value { get; set; }
        public int ValueAfter0 { get; set; }

        public LinkedListNode<int> Current { get; set; }
        public LinkedListNode<int> Next
        {
            get { return Current.Next ?? InternalList.First; }
        }

        public int StepSize { get; set; }

        public SpinLock(int init)
        {
            StepSize = init;
            InternalList = new LinkedList<int>(new[] { 0 });
            Current = InternalList.First;
        }

        public void MoveNext()
        {
            for (var i = 0; i < StepSize; i++)
            {
                Current = Current.Next ?? InternalList.First;
            }

            InternalList.AddAfter(Current, InternalList.Count);
            ValueAfter0 = (InternalList.Find(0).Next ?? InternalList.First).Value;
            Current = Current.Next ?? InternalList.First;
            Position += StepSize + 1;
        }
    }

    public class Day17
    {
        public int Part1(int input, int count)
        {
            var spinLock = new SpinLock(input);

            for (int i = 0; i < count; i++)
            {
                spinLock.MoveNext();
            }

            return spinLock.Next.Value;
        }

        public int Part2(int input, int count)
        {
            var spinLock = new SpinLock(input);


            for (int i = 0; i < count; i++)
            {
                spinLock.MoveNext();
            }

            return spinLock.ValueAfter0;
        }
    }
}