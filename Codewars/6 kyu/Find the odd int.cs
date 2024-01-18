using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            List<int> list = seq.ToList();

            var odd = list.GroupBy(x => x).Where(x => x.Count() % 2 != 0).Select(x => x.Key).ToList();

            return odd[0];
        }
    }
}