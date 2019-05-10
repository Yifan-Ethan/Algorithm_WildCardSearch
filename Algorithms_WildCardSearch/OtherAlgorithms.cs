using System;
using System.Collections.Generic;

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

        //Implementation of the Boyer Moore Horspool Search
        public static int WildcardContains(String str, String search)
        {
            Dictionary<char, int> badmatchtable = new Dictionary<char, int>();
            for (int i = search.Length - 1; i >= 0; i--)
            {
                if (!badmatchtable.ContainsKey(search[i])) badmatchtable.Add(search[i], i + 1);
                else badmatchtable[search[i]] = i + 1;
            }

            int strindex = search.Length - 1;
            while (strindex < str.Length && strindex > -1)
            {
                for (int i = 0; i < search.Length; i++)
                {
                    if (search[search.Length - 1 - i] != str[strindex - i] &&
                        search[search.Length - 1 - i] != '_')
                    {
                        if (!badmatchtable.ContainsKey(str[strindex - i])) strindex = strindex + search.Length;
                        else strindex = strindex + badmatchtable[str[strindex - i]];
                        i = search.Length;
                    }
                    if (i == search.Length - 1) return strindex - search.Length + 1;
                }
            }
            return -1;
        }
    }
}
