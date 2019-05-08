using System;

namespace Algorithms_WildCardSearch
{
    public class SM
    {
        private enum EvalState
        {
            Start,
            Character,
            Percent,
            Underscore,
            End
        }

        public static Boolean Run(string a, string b)
        {
            var state = EvalState.Start;
            var search_index = 0;
            var column_index = 0;
            var match = true;

            while (state != EvalState.End)
            {
                //If column string length is shorter than search value length
                if (column_index >= b.Length) return CheckTrailingPercent(a.Substring(search_index));

                state = IdentifyState(a[RestrainSearchIndex(search_index, a.Length)], search_index.Equals(a.Length));

                switch (state)
                {
                    case EvalState.End:
                        break;

                    case EvalState.Character:
                        match = a[search_index] == b[column_index];
                        search_index++;
                        column_index++;
                        break;

                    case EvalState.Percent:
                        search_index = search_index + NextNonPercentIndex(a.Substring(search_index));
                        if (search_index >= a.Length) return true; //Trailing characters of search value consist only of %
                        int search_chars = NextPercentIndex(a.Substring(search_index));
                        if (search_chars == -1)
                        {
                            if (CompareTrailingCharacters(a.Substring(search_index), b.Substring(column_index))) return true;
                            else return false;
                        }

                        var a_block = a.Substring(search_index, search_chars);
                        var b_searchscope = b.Substring(column_index);

                        int matchingindex = OtherAlgorithms.WildcardContains(b_searchscope, a_block);
                        if (matchingindex == -1) return false;  //Substring of search value does not exist in column value
                        search_index = search_index + search_chars;
                        column_index = column_index + matchingindex + a_block.Length;
                        break;

                    case EvalState.Underscore:
                        search_index++;
                        column_index++;
                        break;
                }
                if (!match) return false;
            }

            if(column_index == b.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static EvalState IdentifyState(char c, Boolean end)
        {
            if (end) return EvalState.End;
            if (c == '%') return EvalState.Percent;
            if (c == '_') return EvalState.Underscore;
            return EvalState.Character;
        }

        private static Boolean CheckTrailingPercent(String search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (search[i] != '%') return false;
            }
            return true;
        }

        private static int RestrainSearchIndex(int search_index, int search_length)
        {
            if (search_index >= search_length) return search_length - 1;
            return search_index;
        }

        private static int NextNonPercentIndex(String search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (search[i] != '%') return i;
            }
            return search.Length;
        }

        private static int NextPercentIndex(String search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (search[i] == '%') return i;
            }
            return -1;
        }

        private static Boolean CompareTrailingCharacters(String s, String v)
        {
            v = v.Substring(v.Length - s.Length);

            var search_index = 0;
            var column_index = 0;

            while (search_index < s.Length)
            {
                if (s[search_index] != v[column_index] && s[search_index] != '_') return false;
                search_index++;
                column_index++;
            }
            return true;
        }
    }
}
