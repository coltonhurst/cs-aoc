using System;
using TwentyTwentySolutions;

namespace cs_aoc
{
    class Program
    {
        static void Main(string[] args)
        {
        	DayOne d1 = new DayOne();
            Console.WriteLine("----- Day 1 -----");
            Console.WriteLine(d1.PartA("./TwentyTwentySolutions/input/day1.txt"));
            Console.WriteLine(d1.PartB("./TwentyTwentySolutions/input/day1.txt"));

            DayTwo d2 = new DayTwo();
            Console.WriteLine("----- Day 2 -----");
            Console.WriteLine(d2.PartA("./TwentyTwentySolutions/input/day2.txt"));
            Console.WriteLine(d2.PartB("./TwentyTwentySolutions/input/day2.txt"));
        }
    }
}
