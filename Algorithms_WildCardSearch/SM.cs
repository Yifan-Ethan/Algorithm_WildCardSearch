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

        public static Boolean Run(string search, string value)
        {
            char[] searchCharArr = search.ToCharArray();
            char[] valueCharArr = value.ToCharArray();

            var state = EvalState.Start;
            var search_index = 0;
            var value_index = 0;
            var match = true;

            while (state != EvalState.End)
            {
                //If column string length is shorter than search value length
                if (value_index >= valueCharArr.Length) return CheckTrailingPercent(OtherAlgorithms.SubCharArray(searchCharArr, search_index));

                state = IdentifyState(searchCharArr[RestrainSearchIndex(search_index, searchCharArr.Length)], search_index.Equals(searchCharArr.Length));

                switch (state)
                {
                    case EvalState.End:
                        break;

                    case EvalState.Character:
                        match = searchCharArr[search_index] == valueCharArr[value_index];
                        search_index++;
                        value_index++;
                        break;

                    case EvalState.Percent:
                        search_index = search_index + NextNonPercentIndex(OtherAlgorithms.SubCharArray(searchCharArr, search_index));
                        if (search_index >= searchCharArr.Length) return true; //Trailing characters of search value consist only of %

                        var search_remaining = OtherAlgorithms.SubCharArray(searchCharArr, search_index);
                        var column_remaining = OtherAlgorithms.SubCharArray(valueCharArr, value_index);

                        //Checks trailing characters when no more percent symbols are found
                        int search_chars = NextPercentIndex(OtherAlgorithms.SubCharArray(searchCharArr, search_index));
                        if (search_chars == -1)
                        {
                            if (CompareTrailingCharacters(search_remaining, column_remaining)) return true;
                            else return false;
                        }

                        //Check if current section of search exists in value
                        var a_block = OtherAlgorithms.SubCharArray(searchCharArr, search_index, search_chars);
                        int matchingindex = OtherAlgorithms.WildcardContains(a_block, column_remaining);
                        if (matchingindex == -1) return false;  //Substring of search value does not exist in column value

                        //Advance index pointers
                        search_index = search_index + search_chars;
                        value_index = value_index + matchingindex + a_block.Length;
                        break;

                    case EvalState.Underscore:
                        search_index++;
                        value_index++;
                        break;
                }
                if (!match) return false;
            }

            if(value_index == value.Length)
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

        private static Boolean CheckTrailingPercent(char[] search)
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

        private static int NextNonPercentIndex(char[] search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (search[i] != '%') return i;
            }
            return search.Length;
        }

        private static int NextPercentIndex(char[] search)
        {
            for (int i = 0; i < search.Length; i++)
            {
                if (search[i] == '%') return i;
            }
            return -1;
        }

        private static Boolean CompareTrailingCharacters(char[] s, char[] v)
        {
            int v_length = v.Length - s.Length;

            if (v_length < 0) return false;

            v = OtherAlgorithms.SubCharArray(v, v_length);

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
