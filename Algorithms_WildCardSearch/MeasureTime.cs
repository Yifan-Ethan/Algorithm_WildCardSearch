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
                f("ABC%EF%GHI%MNQ%XYZ", "ABCDEFGHIJKLMNQRSTUVWXYZ");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
