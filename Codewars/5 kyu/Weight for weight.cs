using System;
using System.Linq;

public class WeightSort
{

    public static string orderWeight(string strng)
    {
        string[] weights = strng.Split(" ");

        var ordered = weights.OrderBy(weight => weight.Select(digit => digit - '0').Sum()).ThenBy(weight => weight);

        return String.Join(' ', ordered);
    }
}