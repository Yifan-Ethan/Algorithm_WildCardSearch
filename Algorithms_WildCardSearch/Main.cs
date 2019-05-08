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

            //Measure time for small parameters
            var elapsedMs_naive = MeasureTime.smallparams(run_naive, 1000000);
            var elapsedMs_TSIPS = MeasureTime.smallparams(run_TSIPS, 1000000);
            var elapsedMs_SM = MeasureTime.smallparams(run_SM, 1000000);
            Console.WriteLine("Small Parameters, Search and Value both less than 30 characters");
            Console.WriteLine("Naive solution: " + elapsedMs_naive + " milliseconds");
            Console.WriteLine("Three Step Iterative Partial Search: " + elapsedMs_TSIPS + " milliseconds");
            Console.WriteLine("State Machine: " + elapsedMs_SM + " milliseconds");
            Console.WriteLine();

            //End
            Console.ReadKey();
        }
    }
}
