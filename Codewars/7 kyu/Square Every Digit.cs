using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        if (n == 0) return 0;

        string res = "";

        while (n > 0)
        {
            int digit = n % 10;
            res = res.Insert(0, Math.Pow(digit, 2.0).ToString());
            n /= 10;
        }

        return Convert.ToInt32(res);
    }
}