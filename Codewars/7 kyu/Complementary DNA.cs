public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        string result = "";

        foreach (char el in dna)
        {
            switch (el)
            {
                case 'A':
                    result += 'T';
                    break;
                case 'T':
                    result += 'A';
                    break;
                case 'C':
                    result += 'G';
                    break;
                case 'G':
                    result += 'C';
                    break;
                default:
                    result += el;
                    break;

            }
        }

        return result;
    }
}