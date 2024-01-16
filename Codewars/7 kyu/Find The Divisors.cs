using System.Collections.Generic;

public class Kata
{
    public static int[]? Divisors(int n)
    {
        List<int> res = new List<int>(); // create new list

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                res.Add(i);
            }
        }

        return res.Count == 0 ? null : res.ToArray();
    }
}