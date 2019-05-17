using System;
using System.Collections.Generic;

namespace Algorithms_WildCardSearch
{
    public class TSIWCS
    {
        public static Boolean Run(string search, string value)
        {
            char[] searchCharArr = search.ToCharArray();
            char[] valueCharArr = value.ToCharArray();
            List<int> percentIndex = new List<int>();

            //Check length of search
            for (int i = 0; i < searchCharArr.Length; i++)
            {
                if (searchCharArr[i] == '%') percentIndex.Add(i);
            }
            if (searchCharArr.Length - percentIndex.Count > valueCharArr.Length) return false;

            var firstloop = true;
            for (int i = 0; i < percentIndex.Count; i++)
            {
                int index = percentIndex[i];
                if (i > 0) index = index - percentIndex[i - 1] - 1;

                var search_section = OtherAlgorithms.SubCharArray(searchCharArr, 0, index);
                int containsindex = -1;

                //Match leading characters
                if (firstloop)
                {
                    if (!OtherAlgorithms.WildcardEquals(OtherAlgorithms.SubCharArray(valueCharArr, 0, index), search_section)) return false;
                    valueCharArr = OtherAlgorithms.SubCharArray(valueCharArr, search_section.Length);
                    firstloop = false;
                }
                //Match intermediate characters
                else
                {
                    containsindex = OtherAlgorithms.WildcardContains(search_section, valueCharArr);
                    if (containsindex == -1) return false;
                    valueCharArr = OtherAlgorithms.SubCharArray(valueCharArr, containsindex + search_section.Length);
                }

                searchCharArr = OtherAlgorithms.SubCharArray(searchCharArr, index + 1);
            }

            //Match trailing characters
            if (!OtherAlgorithms.WildcardEquals(OtherAlgorithms.SubCharArray(valueCharArr, valueCharArr.Length - searchCharArr.Length), searchCharArr)) return false;

            return true;
        }
    }
}