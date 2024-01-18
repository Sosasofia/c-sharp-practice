public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int start = 0;
        bool isValid = false;

        for (int i = 0; i < walk.Length; i++)
        {
            switch (walk[i])
            {
                case "n":
                    start++;
                    break;
                case "s":
                    start--;
                    break;
                case "e":
                    start += 2;
                    break;
                case "w":
                    start -= 2;
                    break;
                default:
                    break;
            }
        }

        if (start == 0 && walk.Length == 10)
        {
            isValid = true;
        }

        return isValid;
    }
}