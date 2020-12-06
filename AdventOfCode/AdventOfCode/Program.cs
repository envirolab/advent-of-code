using System;
using System.Collections;
using System.IO;

namespace AdventOfCode
{
    class Program
    {

        static void Main(string[] args)
        {
            //Day1Part1();
            //Day1Part2();
            //Day2Part1();
            Day2Part2();
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
            sr.Close();
            fs.Close();

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
            sr.Close();
            fs.Close();

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

        static void Day2Part1()
        {
            FileStream fs = new FileStream(@"C:\Users\medun\source\repos\advent-of-code\AdventOfCode\AdventOfCode\Day2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            ArrayList alInst1 = new ArrayList();
            ArrayList alInst2 = new ArrayList();
            ArrayList alAlpha = new ArrayList();
            ArrayList alPwd = new ArrayList();

            while ((line = sr.ReadLine()) != null)
            {
                string[] sPwdLine = line.Split(' ');
                alInst1.Add(sPwdLine[0].Trim().Substring(0,sPwdLine[0].IndexOf('-')));
                alInst2.Add(sPwdLine[0].Trim().Substring(sPwdLine[0].IndexOf('-')+1));
                alAlpha.Add(sPwdLine[1].Trim().Trim(':'));
                alPwd.Add(sPwdLine[2].Trim())
;            }
            sr.Close();
            fs.Close();

            int i = 0;
            int charCount = 0;
            ArrayList alGoodPasswords = new ArrayList();
            foreach (string pwd in alPwd)
            {
                char[] cPwd = pwd.ToCharArray();
                foreach(char c in cPwd)
                {
                    if (c == Convert.ToChar(alAlpha[i]))
                    {
                        charCount++;
                    }
                }
                if ((charCount >= Convert.ToInt32(alInst1[i])) && (charCount <= Convert.ToInt32(alInst2[i])))
                {
                    alGoodPasswords.Add(pwd);
                }
                i++;
                charCount = 0;
            }
            Console.WriteLine("The number of good passwords found are:" + alGoodPasswords.Count);
            Console.WriteLine("The good passwords are as follows:");
            foreach (string pwd in alGoodPasswords)
            {
                Console.WriteLine(pwd);
            }
        }

        static void Day2Part2()
        {
            FileStream fs = new FileStream(@"C:\Users\medun\source\repos\advent-of-code\AdventOfCode\AdventOfCode\Day2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            ArrayList alInst1 = new ArrayList();
            ArrayList alInst2 = new ArrayList();
            ArrayList alAlpha = new ArrayList();
            ArrayList alPwd = new ArrayList();

            while ((line = sr.ReadLine()) != null)
            {
                string[] sPwdLine = line.Split(' ');
                alInst1.Add(sPwdLine[0].Trim().Substring(0, sPwdLine[0].IndexOf('-')));
                alInst2.Add(sPwdLine[0].Trim().Substring(sPwdLine[0].IndexOf('-') + 1));
                alAlpha.Add(sPwdLine[1].Trim().Trim(':'));
                alPwd.Add(sPwdLine[2].Trim())
;
            }
            sr.Close();
            fs.Close();

            int i = 0;
            ArrayList alGoodPasswords = new ArrayList();
            foreach (string pwd in alPwd)
            {
                char[] cPwd = pwd.ToCharArray();
                int FirstPosition = Convert.ToInt32(alInst1[i]);
                int SecondPosition = Convert.ToInt32(alInst2[i]);
                int iCharCount = 0;
                if ((cPwd[FirstPosition - 1].Equals(Convert.ToChar(alAlpha[i]))))
                {
                    iCharCount++;
                }

                if (cPwd[SecondPosition - 1].Equals(Convert.ToChar(alAlpha[i])))
                {
                    iCharCount++;
                }

                if (iCharCount==1)
                    alGoodPasswords.Add(pwd);
                i++;
            }
            Console.WriteLine("The number of good passwords found are:" + alGoodPasswords.Count);
            Console.WriteLine("The good passwords are as follows:");
            foreach (string pwd in alGoodPasswords)
            {
                Console.WriteLine(pwd);
            }
        }
    }
}
