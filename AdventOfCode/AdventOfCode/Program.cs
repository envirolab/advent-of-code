using System;
using System.Collections;
using System.IO;

namespace AdventOfCode
{
    class Program
    {

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\medun\source\repos\advent-of-code\AdventOfCode\AdventOfCode\Day1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            ArrayList alNumbers = new ArrayList();
            while ((line = sr.ReadLine()) != null)
            {
                alNumbers.Add(line);
            }
            int[] Numbers = (int[])alNumbers.ToArray(typeof(int));
            int Index = 0;
            int iFirstVal = 0;
            int iSecondVal = 0;
            while (Index < Numbers.Length-1)
            {
                foreach (int i in Numbers)
                {
                    if (i + Numbers[Index] == 2020)
                    {
                        iFirstVal = i;
                        iSecondVal = Numbers[Index];
                        break;
                    }
                    else
                        Index++;
                }
            }
            Console.WriteLine("Numbers are "+iFirstVal + " and " + iSecondVal);
        }
    }
}
