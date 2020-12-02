using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class Utilities
    {

        public int[] ObtainIntArrayFromWeb (string sURL)
        {
            System.Console.WriteLine(new System.Net.WebClient().DownloadString(sURL));

            return null;
        }

        public bool EvaluateIntSum(int iValuetoEvaluate, int iExpectedSum)
        {

            return false;
        }
    }
}
