using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_WildCardSearch
{
    class OtherAlgorithms
    {
        private static Random random = new Random();

        public static Boolean WildcardEquals(char[] value, char[] search)
        {
            if (value.Length < search.Length) return false;
            for (int i = 0; i < search.Length; i++)
            {
                if (!(search[i] == value[i]) && search[i] != '_') return false;
            }
            return true;
        }

        //Implementation of the Boyer Moore Horspool Search
        public static int WildcardContains(char[] search, char[] value)
        {
            Dictionary<char, int> badmatchtable = new Dictionary<char, int>();
            for (int i = search.Length - 1; i >= 0; i--)
            {
                if (!badmatchtable.ContainsKey(search[i])) badmatchtable.Add(search[i], i + 1);
                else badmatchtable[search[i]] = i + 1;
            }

            int valueindex = search.Length - 1;
            if (valueindex < 0) return 0;   //valueindex less than 0 means empty search string

            while (valueindex < value.Length)
            {
                for (int i = 0; i < search.Length; i++)
                {
                    if (search[search.Length - 1 - i] != value[valueindex - i] &&
                        search[search.Length - 1 - i] != '_')
                    {
                        if (!badmatchtable.ContainsKey(value[valueindex - i])) valueindex = valueindex + search.Length;
                        else valueindex = valueindex + badmatchtable[value[valueindex - i]];
                        i = search.Length;
                    }
                    if (i == search.Length - 1) return valueindex - search.Length + 1;
                }
            }
            return -1;
        }

        public static Char[] SubCharArray(Char[] array, int start)
        {
            if (start < 0) return new char[0];
            char[] result = new char[array.Length - start];
            Array.Copy(array, start, result, 0, array.Length - start);
            return result;
        }

        public static Char[] SubCharArray(Char[] array, int start, int length)
        {
            char[] result = new char[length];
            Array.Copy(array, start, result, 0, length);
            return result;
        }
        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomSearchString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789%_";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
