using System;

namespace Algorithms_WildCardSearch
{
    class OtherAlgorithms
    {
        public static Boolean WildcardEquals(String str, String search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (!(char.ToUpperInvariant(search[i]) == char.ToUpperInvariant(str[i])) && search[i] != '_') return false;
            }
            return true;
        }

        public static int WildcardContains(String str, String search)
        {
            for (int i = 0; i < str.Length - search.Length + 1; i++)
            {
                if (Equals(str.Substring(i, search.Length), search)) return i;
            }
            return -1;
        }
    }
}
