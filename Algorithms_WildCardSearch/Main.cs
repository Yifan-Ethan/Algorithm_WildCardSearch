using System;

namespace Algorithms_WildCardSearch
{
    public class Wildcardsearch
    {
        public static void Main(string[] args)
        {
            //Delegate functions
            Func<string, string, Boolean> run_naive = new Func<string, string, Boolean>(Naive.Run);
            Func<string, string, Boolean> run_TSIPS = new Func<string, string, Boolean>(TSIWCS.Run);
            Func<string, string, Boolean> run_SM = new Func<string, string, Boolean>(SM.Run);

            int i = 100;
            int k = 5;
            
            //Measure time for dynamicSearch method - match
            var elapsedMs_naive = 0.0;
            var elapsedMs_TSIPS = 0.0;
            var elapsedMs_SM = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive += MeasureTime.dynamicSearch(run_naive, i);
                elapsedMs_TSIPS += MeasureTime.dynamicSearch(run_TSIPS, i);
                elapsedMs_SM += MeasureTime.dynamicSearch(run_SM, i);
            }
            elapsedMs_naive /= k;
            elapsedMs_TSIPS /= k;
            elapsedMs_SM /= k;

            Console.WriteLine("Match, Dynamic Search has 10 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM + " microseconds");
            Console.WriteLine("");

            //Measure time for dynamicSearch_ method - mismatch
            var elapsedMs_naive_ = 0.0;
            var elapsedMs_TSIPS_ = 0.0;
            var elapsedMs_SM_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive_ += MeasureTime.dynamicSearch_(run_naive, i);
                elapsedMs_TSIPS_ += MeasureTime.dynamicSearch_(run_TSIPS, i);
                elapsedMs_SM_ += MeasureTime.dynamicSearch_(run_SM, i);
            }
            elapsedMs_naive_ /= k;
            elapsedMs_TSIPS_ /= k;
            elapsedMs_SM_ /= k;
            Console.WriteLine("Mismatch, Dynamic Search has 10 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for dynamicSearch2 method - match
            var elapsedMs_naive2 = 0.0;
            var elapsedMs_TSIPS2 = 0.0;
            var elapsedMs_SM2 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive2 += MeasureTime.dynamicSearch2(run_naive, i);
                elapsedMs_TSIPS2 += MeasureTime.dynamicSearch2(run_TSIPS, i);
                elapsedMs_SM2 += MeasureTime.dynamicSearch2(run_SM, i);
            }
            elapsedMs_naive2 /= k;
            elapsedMs_TSIPS2 /= k;
            elapsedMs_SM2 /= k;
            Console.WriteLine("Match, Dynamic Search has 100 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive2 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS2 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM2 + " microseconds");
            Console.WriteLine("");

            //Measure time for dynamicSearch2_ method - mismatch
            var elapsedMs_naive2_ = 0.0;
            var elapsedMs_TSIPS2_ = 0.0;
            var elapsedMs_SM2_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive2_ += MeasureTime.dynamicSearch2_(run_naive, i);
                elapsedMs_TSIPS2_ += MeasureTime.dynamicSearch2_(run_TSIPS, i);
                elapsedMs_SM2_ += MeasureTime.dynamicSearch2_(run_SM, i);
            }
            elapsedMs_naive2_ /= k;
            elapsedMs_TSIPS2_ /= k;
            elapsedMs_SM2_ /= k;
            Console.WriteLine("Mismatch, Dynamic Search has 100 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive2_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS2_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM2_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for dynamicSearch3 method - match
            var elapsedMs_naive3 = 0.0;
            var elapsedMs_TSIPS3 = 0.0;
            var elapsedMs_SM3 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive3 += MeasureTime.dynamicSearch3(run_naive, i);
                elapsedMs_TSIPS3 += MeasureTime.dynamicSearch3(run_TSIPS, i);
                elapsedMs_SM3 += MeasureTime.dynamicSearch3(run_SM, i);
            }
            elapsedMs_naive3 /= k;
            elapsedMs_TSIPS3 /= k;
            elapsedMs_SM3 /= k;
            Console.WriteLine("Match, Dynamic Search has 500 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive3 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS3 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM3 + " microseconds");
            Console.WriteLine("");

            //Measure time for dynamicSearch3_ method - mismatch
            var elapsedMs_naive3_ = 0.0;
            var elapsedMs_TSIPS3_ = 0.0;
            var elapsedMs_SM3_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive3_ += MeasureTime.dynamicSearch3_(run_naive, i);
                elapsedMs_TSIPS3_ += MeasureTime.dynamicSearch3_(run_TSIPS, i);
                elapsedMs_SM3_ += MeasureTime.dynamicSearch3_(run_SM, i);
            }
            elapsedMs_naive3_ /= k;
            elapsedMs_TSIPS3_ /= k;
            elapsedMs_SM3_ /= k;
            Console.WriteLine("Mismatch, Dynamic Search has 500 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive3_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS3_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM3_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for dynamicSearch4 method - match
            var elapsedMs_naive4 = 0.0;
            var elapsedMs_TSIPS4 = 0.0;
            var elapsedMs_SM4 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive4 += MeasureTime.dynamicSearch4(run_naive, i);
                elapsedMs_TSIPS4 += MeasureTime.dynamicSearch4(run_TSIPS, i);
                elapsedMs_SM4 += MeasureTime.dynamicSearch4(run_SM, i);
            }
            elapsedMs_naive4 /= k;
            elapsedMs_TSIPS4 /= k;
            elapsedMs_SM4 /= k;
            Console.WriteLine("Match, Dynamic Search has 1,000 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive4 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS4 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM4 + " microseconds");
            Console.WriteLine("");

            //Measure time for dynamicSearch4_ method - mismatch
            var elapsedMs_naive4_ = 0.0;
            var elapsedMs_TSIPS4_ = 0.0;
            var elapsedMs_SM4_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive4_ += MeasureTime.dynamicSearch4_(run_naive, i);
                elapsedMs_TSIPS4_ += MeasureTime.dynamicSearch4_(run_TSIPS, i);
                elapsedMs_SM4_ += MeasureTime.dynamicSearch4_(run_SM, i);
            }
            elapsedMs_naive4_ /= k;
            elapsedMs_TSIPS4_ /= k;
            elapsedMs_SM4_ /= k;
            Console.WriteLine("Mismatch, Dynamic Search has 1,000 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive4_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS4_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM4_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("");

            //Measure time for staticSearch method - match
            var elapsedMs_naive5 = 0.0;
            var elapsedMs_TSIPS5 = 0.0;
            var elapsedMs_SM5 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive5 += MeasureTime.staticSearch(run_naive, i);
                elapsedMs_TSIPS5 += MeasureTime.staticSearch(run_TSIPS, i);
                elapsedMs_SM5 += MeasureTime.staticSearch(run_SM, i);
            }
            elapsedMs_naive5 /= k;
            elapsedMs_TSIPS5 /= k;
            elapsedMs_SM5 /= k;
            Console.WriteLine("Match, Static Search has 100 characters and Value has 100 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive5 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS5 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM5 + " microseconds");
            Console.WriteLine("");

            //Measure time for staticSearch_ method - mismatch
            var elapsedMs_naive5_ = 0.0;
            var elapsedMs_TSIPS5_ = 0.0;
            var elapsedMs_SM5_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive5_ += MeasureTime.staticSearch_(run_naive, i);
                elapsedMs_TSIPS5_ += MeasureTime.staticSearch_(run_TSIPS, i);
                elapsedMs_SM5_ += MeasureTime.staticSearch_(run_SM, i);
            }
            elapsedMs_naive5_ /= k;
            elapsedMs_TSIPS5_ /= k;
            elapsedMs_SM5_ /= k;
            Console.WriteLine("Mismatch, Static Search has 100 characters and Value has 100 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive5_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS5_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM5_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for staticSearch2 method - match
            var elapsedMs_naive6 = 0.0;
            var elapsedMs_TSIPS6 = 0.0;
            var elapsedMs_SM6 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive6 += MeasureTime.staticSearch2(run_naive, i);
                elapsedMs_TSIPS6 += MeasureTime.staticSearch2(run_TSIPS, i);
                elapsedMs_SM6 += MeasureTime.staticSearch2(run_SM, i);
            }
            elapsedMs_naive6 /= k;
            elapsedMs_TSIPS6 /= k;
            elapsedMs_SM6 /= k;
            Console.WriteLine("Match, Static Search has 100 characters and Value has 1,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive6 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS6 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM6 + " microseconds");
            Console.WriteLine("");

            //Measure time for staticSearch2_ method - mismatch
            var elapsedMs_naive6_ = 0.0;
            var elapsedMs_TSIPS6_ = 0.0;
            var elapsedMs_SM6_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive6_ += MeasureTime.staticSearch2_(run_naive, i);
                elapsedMs_TSIPS6_ += MeasureTime.staticSearch2_(run_TSIPS, i);
                elapsedMs_SM6_ += MeasureTime.staticSearch2_(run_SM, i);
            }
            elapsedMs_naive6_ /= k;
            elapsedMs_TSIPS6_ /= k;
            elapsedMs_SM6_ /= k;
            Console.WriteLine("Mismatch, Static Search has 100 characters and Value has 1,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive6_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS6_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM6_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for staticSearch3 method - match
            var elapsedMs_naive7 = 0.0;
            var elapsedMs_TSIPS7 = 0.0;
            var elapsedMs_SM7 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive7 += MeasureTime.staticSearch3(run_naive, i);
                elapsedMs_TSIPS7 += MeasureTime.staticSearch3(run_TSIPS, i);
                elapsedMs_SM7 += MeasureTime.staticSearch3(run_SM, i);
            }
            elapsedMs_naive7 /= k;
            elapsedMs_TSIPS7 /= k;
            elapsedMs_SM7 /= k;
            Console.WriteLine("Match, Static Search has 100 characters and Value has 10,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive7 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS7 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM7 + " microseconds");
            Console.WriteLine("");

            //Measure time for staticSearch3_ method - mismatch
            var elapsedMs_naive7_ = 0.0;
            var elapsedMs_TSIPS7_ = 0.0;
            var elapsedMs_SM7_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive7_ += MeasureTime.staticSearch3_(run_naive, i);
                elapsedMs_TSIPS7_ += MeasureTime.staticSearch3_(run_TSIPS, i);
                elapsedMs_SM7_ += MeasureTime.staticSearch3_(run_SM, i);
            }
            elapsedMs_naive7_ /= k;
            elapsedMs_TSIPS7_ /= k;
            elapsedMs_SM7_ /= k;
            Console.WriteLine("Mismatch, Static Search has 100 characters and Value has 10,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive7_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS7_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM7_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("");

            //Measure time for staticSearch4 method - match
            var elapsedMs_naive8 = 0.0;
            var elapsedMs_TSIPS8 = 0.0;
            var elapsedMs_SM8 = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive8 += MeasureTime.staticSearch4(run_naive, i);
                elapsedMs_TSIPS8 += MeasureTime.staticSearch4(run_TSIPS, i);
                elapsedMs_SM8 += MeasureTime.staticSearch4(run_SM, i);
            }
            elapsedMs_naive8 /= k;
            elapsedMs_TSIPS8 /= k;
            elapsedMs_SM8 /= k;
            Console.WriteLine("Match, Static Search has 100 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive8 + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS8 + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM8 + " microseconds");
            Console.WriteLine("");

            //Measure time for staticSearch4_ method - mismatch
            var elapsedMs_naive8_ = 0.0;
            var elapsedMs_TSIPS8_ = 0.0;
            var elapsedMs_SM8_ = 0.0;
            for (int j = 0; j < k; j++)
            {
                elapsedMs_naive8_ += MeasureTime.staticSearch4_(run_naive, i);
                elapsedMs_TSIPS8_ += MeasureTime.staticSearch4_(run_TSIPS, i);
                elapsedMs_SM8_ += MeasureTime.staticSearch4_(run_SM, i);
            }
            elapsedMs_naive8_ /= k;
            elapsedMs_TSIPS8_ /= k;
            elapsedMs_SM8_ /= k;
            Console.WriteLine("Mismatch, Static Search has 100 characters and Value has 100,000 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive8_ + " microseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS8_ + " microseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM8_ + " microseconds");
            Console.WriteLine("");
            Console.WriteLine("Fully Completed!");

            //End
            Console.ReadKey();
        }
    }
}
