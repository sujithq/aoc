using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public enum Day25StateTypeEnum
    {
        A, B, C, D, E, F
    }
    public enum Day25MovementTypeEnum
    {
        Right, Left
    }

    public class Day25StateAction
    {
        public Day25StateTypeEnum State { get; set; }
        public int Condition { get; set; }
        public int WriteValue { get; set; }
        public Day25MovementTypeEnum MovementType { get; set; }
        public Day25StateTypeEnum MoveToState { get; set; }
    }


    public class Day25
    {
        public List<Day25StateAction> StateActions { get; }
        public Day25StateTypeEnum CurrentState { get; set; } = Day25StateTypeEnum.A;

        public LinkedList<int> StateMachine { get; } = new LinkedList<int>(new[] { 0 });

        public LinkedListNode<int> CurrentNode { get; set; }
        public int CheckSum => StateMachine.Sum();

        public Day25(string input)
        {
            StateActions = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(s =>
            {

                var splitLine = s.Split(',');
                return new Day25StateAction { State = (Day25StateTypeEnum)Enum.Parse(typeof(Day25StateTypeEnum), splitLine[0]), Condition = int.Parse(splitLine[1]), WriteValue = int.Parse(splitLine[2]), MovementType = (Day25MovementTypeEnum)Enum.Parse(typeof(Day25MovementTypeEnum), splitLine[3]), MoveToState = (Day25StateTypeEnum)Enum.Parse(typeof(Day25StateTypeEnum), splitLine[4]) };
            }).ToList();
            CurrentNode = StateMachine.First;
        }


        public void Step()
        {
            //Search For State And Condition:
            var state = StateActions.First(f => f.State == CurrentState && f.Condition == CurrentNode.Value);
            //Write Value
            CurrentNode.Value = state.WriteValue;
            //Move One Slot
            if (state.MovementType == Day25MovementTypeEnum.Right)
            {
                CurrentNode = CurrentNode.Next ?? CurrentNode.List.AddAfter(CurrentNode, 0);
            }
            else
            {
                CurrentNode = CurrentNode.Previous ?? CurrentNode.List.AddBefore(CurrentNode, 0);
            }
            //Continue with new state
            CurrentState = state.MoveToState;

        }

        
    }
}