﻿using System;
using System.Collections;
using System.IO;

namespace AdventOfCode
{
    class Program
    {

        static void Main(string[] args)
        {
            Day1Part1();
            Day1Part2();
        }

        static void Day1Part1()
        {
            FileStream fs = new FileStream(@"C:\Users\medun\source\repos\advent-of-code\AdventOfCode\AdventOfCode\Day1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            ArrayList alNumbers = new ArrayList();
            while ((line = sr.ReadLine()) != null)
            {
                alNumbers.Add(Convert.ToInt32(line.Trim()));
            }
            int[] Numbers = (int[])alNumbers.ToArray(typeof(int));

            int Index = 0;
            bool bContinue = true;
            while (Index < Numbers.Length - 1)
            {
                foreach (int i in Numbers)
                {
                    if (i + Numbers[Index] == 2020)
                    {
                        Console.WriteLine("------Day 1 Part 1------");
                        Console.WriteLine("Numbers are " + i + " and " + Numbers[Index]);
                        Console.WriteLine("The multiplied value of the numbers is " + i * Numbers[Index]);
                        bContinue = false;
                        break;
                    }
                }
                if (!bContinue)
                    break;
                else
                    Index++;
            }
        }

        static void Day1Part2()
        {
            FileStream fs = new FileStream(@"C:\Users\medun\source\repos\advent-of-code\AdventOfCode\AdventOfCode\Day1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            ArrayList alNumbers = new ArrayList();
            while ((line = sr.ReadLine()) != null)
            {
                alNumbers.Add(Convert.ToInt32(line.Trim()));
            }
            int[] Numbers = (int[])alNumbers.ToArray(typeof(int));

            int Index = 0;
            bool bContinue = true;
            while (Index < Numbers.Length - 1)
            {
                foreach (int i in Numbers)
                {
                    foreach (int j in Numbers)
                    {
                        if (i + j + Numbers[Index] == 2020)
                        {
                            Console.WriteLine("------Day 1 Part 2------");
                            Console.WriteLine("Numbers are " + i + " and " + j + " and " + Numbers[Index]);
                            Console.WriteLine("The multiplied value of the numbers is " + i * j * Numbers[Index]);
                            bContinue = false;
                            break;
                        }
                    }
                    if (!bContinue)
                        break;
                }
                if (!bContinue)
                    break;
                else
                    Index++;
            }
        }
    }
}
