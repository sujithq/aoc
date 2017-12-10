using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aoc2017Console
{
    class Program
    {

        

        static void Main(string[] args)
        {
            var input = @"{}".Replace("{","(").Replace("}",")");
            //Console.WriteLine("Score ({0}) for '{1}'", Score(input, 1), input);
            //input = "(())";
            //Console.WriteLine("Score ({0}) for '{1}'", Score(input, 1), input);
            //input = "((),())";
            //Console.WriteLine("Score ({0}) for '{1}'", Score(input, 1), input);
            Console.ReadKey();
            
        }

        
    }
}
