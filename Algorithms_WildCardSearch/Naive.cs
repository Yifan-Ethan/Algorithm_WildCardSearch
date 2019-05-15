using System;
using System.Collections.Generic;

namespace Algorithms_WildCardSearch
{
    public class Naive
    {
        public static Boolean Run(string search, string value)
        {
            char[] searchCharArr = search.ToCharArray();
            char[] valueCharArr = value.ToCharArray();
            int indexAfterPercent = 0, valueIndex = 0, toggleBit = 0, skip = 0;
            char tempSearchChar, tempValueChar;
            List<int> tempArr = new List<int>();
            for (int i = 0; i < searchCharArr.Length; i++)
            {
                if (valueIndex >= valueCharArr.Length)
                    return false;
                tempSearchChar = searchCharArr[i];
                tempValueChar = valueCharArr[valueIndex];
                if (tempSearchChar == '%')
                {
                    tempArr.Clear();
                    for (int j = i; j < searchCharArr.Length; j++)
                    {
                        if (searchCharArr[j] == '_')
                        {
                            for (int k = valueIndex; k < valueCharArr.Length; k++)
                            {
                                tempArr.Add(k);
                            }
                            indexAfterPercent = j;
                            skip = 1;
                            break;
                        }
                        if (searchCharArr[j] != '%')
                        {
                            indexAfterPercent = j;
                            tempSearchChar = searchCharArr[j];
                            break;
                        }
                        if (j == (searchCharArr.Length - 1))
                        {
                            return true;
                        }
                    }
                    if (skip == 0)
                    {
                        for (int j = valueIndex; j < valueCharArr.Length; j++)
                        {
                            if (valueCharArr[j] == tempSearchChar)
                                tempArr.Add(j);
                        }
                    }
                    skip = 0;
                    if (tempArr.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        valueIndex = tempArr[0];
                        tempValueChar = valueCharArr[valueIndex];
                        tempArr.RemoveAt(0);
                        i = indexAfterPercent;
                        toggleBit = 1;
                    }
                }
                if (((tempValueChar != tempSearchChar) && (tempSearchChar != '_')) || ((i == (searchCharArr.Length - 1)) && (valueIndex != (valueCharArr.Length - 1))))
                {
                    if (tempArr.Count != 0)
                    {
                        if (toggleBit == 1)
                            toggleBit = 0;
                        else
                        {
                            valueIndex = tempArr[0];
                            tempValueChar = valueCharArr[tempArr[0]];
                            tempArr.RemoveAt(0);
                            i = indexAfterPercent;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                valueIndex++;
            }
            return true;
        }
    }
}
