using System;
using TwentyTwentySolutions;

namespace cs_aoc
{
    class Program
    {
        static void Main(string[] args)
        {
        	const string puzzleInputPath = "./TwentyTwentySolutions/input/day1.txt";

            DayOne d1 = new DayOne();
            Console.WriteLine("----- Day 1 -----");
            Console.WriteLine(d1.PartA(puzzleInputPath));
            Console.WriteLine(d1.PartB(puzzleInputPath));
        }
    }
}
