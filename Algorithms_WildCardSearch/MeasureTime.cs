using System;

namespace Algorithms_WildCardSearch
{
    class MeasureTime
    {
        public static double dynamicSearch(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(10);
                string value = OtherAlgorithms.RandomMatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(10);
                string value = OtherAlgorithms.RandomMismatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch2(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(100);
                string value = OtherAlgorithms.RandomMatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch2_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(100);
                string value = OtherAlgorithms.RandomMismatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch3(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(500);
                string value = OtherAlgorithms.RandomMatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch3_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(500);
                string value = OtherAlgorithms.RandomMismatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch4(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(1000);
                string value = OtherAlgorithms.RandomMatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double dynamicSearch4_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(1000);
                string value = OtherAlgorithms.RandomMismatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(100);
                string value = OtherAlgorithms.RandomMatchString(100);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(100);
                string value = OtherAlgorithms.RandomMismatchString(100);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch2(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(100);
                string value = OtherAlgorithms.RandomMatchString(1000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch2_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(100);
                string value = OtherAlgorithms.RandomMismatchString(1000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch3(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(100);
                string value = OtherAlgorithms.RandomMatchString(10000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch3_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(100);
                string value = OtherAlgorithms.RandomMismatchString(10000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch4(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMatchSearchString(100);
                string value = OtherAlgorithms.RandomMatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

        public static double staticSearch4_(Func<string, string, Boolean> f, int iterations)
        {
            double time = 0;
            for (int i = 0; i < iterations; i++)
            {
                string search = OtherAlgorithms.RandomMismatchSearchString(100);
                string value = OtherAlgorithms.RandomMismatchString(100000);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f(search, value);
                watch.Stop();
                time = time + watch.Elapsed.TotalMilliseconds * 1000;
            }
            return time;
        }

    }
}
