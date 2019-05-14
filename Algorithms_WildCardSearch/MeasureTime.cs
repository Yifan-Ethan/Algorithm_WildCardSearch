using System;

namespace Algorithms_WildCardSearch
{
    class MeasureTime
    {
        public static long smallparams(Func<string, string, Boolean> f, int iterations)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomSearchString(10);
                string value = OtherAlgorithms.RandomString(10);
                f(search, value);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
