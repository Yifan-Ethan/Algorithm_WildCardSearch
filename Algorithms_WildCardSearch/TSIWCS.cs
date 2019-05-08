using System;

namespace Algorithms_WildCardSearch
{
    public class TSIWCS
    {
        public static Boolean Run(string a, string b)
        {
            //Check length of search value
            if (a.Replace("%", "").Length > b.Length) return false;

            var firstloop = true;
            for (int PercentIndex = a.IndexOf('%'); PercentIndex != -1; PercentIndex = a.IndexOf('%'))
            {
                var a_section = a.Substring(0, PercentIndex);
                int containsindex = -1;

                //Match leading characters
                if (firstloop)
                {
                    if (!OtherAlgorithms.WildcardEquals(b.Substring(0, PercentIndex), a_section)) return false;
                    b = b.Substring(a_section.Length);
                    firstloop = false;
                }
                //Match intermediate characters
                else
                {
                    containsindex = OtherAlgorithms.WildcardContains(b, a_section);
                    if (containsindex == -1) return false;
                    b = b.Substring(containsindex + a_section.Length);
                }

                a = a.Substring(PercentIndex + 1);
            }

            //Match trailing characters
            if (!OtherAlgorithms.WildcardEquals(b.Substring(b.Length - a.Length), a)) return false;

            return true;
        }
    }
}
