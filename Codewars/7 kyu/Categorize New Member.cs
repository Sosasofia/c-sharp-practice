using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        string[] result = new string[data.Length];

        for (int i = 0; i < data.Length; i++)
        {

            if (data[i][0] >= 55 && data[i][1] > 7)
            {
                result[i] = "Senior";
            }
            else
            {
                result[i] = "Open";
            }
        }

        return result;
    }
}