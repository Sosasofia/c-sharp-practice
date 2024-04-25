using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Encrypt(string text, int n)
    {

        if (n <= 0 || string.IsNullOrEmpty(text))
            return text;

        for (int i = n; i > 0; i--)
        {
            string oddChars = text.Where((c, j) => j % 2 != 0).Aggregate("", (current, c) => current + c);
            string evenChars = text.Where((c, j) => j % 2 == 0).Aggregate("", (current, c) => current + c);


            text = string.Concat(oddChars, evenChars);
        }

        return text;
    }

    public static string Decrypt(string encryptedText, int n)
    {
        if (n <= 0 || string.IsNullOrEmpty(encryptedText))
            return encryptedText;

        for (int i = n; i > 0; i--)
        {
            string oddChars = encryptedText.Substring(0, encryptedText.Length / 2);
            string evenChars = encryptedText.Substring(encryptedText.Length / 2);

            encryptedText = string.Concat(Enumerable.Range(0, encryptedText.Length).Select(j => j % 2 == 0 ? evenChars[j / 2] : oddChars[j / 2]));
        }

        return encryptedText;
    }
}