using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AsyncAwait
{
    public static class DinnerUtils
    {
        public static void ServeDinner()
        {
            Stopwatch sw = Stopwatch.StartNew();
            CleanTable();
            BoilPotatoes();
            MashPotatoes();
            FryShnitzel();
            PourWater();
            Console.WriteLine("Serving dinner took us: " + sw.ElapsedMilliseconds + " ms");
        }

        private static void CleanTable()
        {
            Console.WriteLine($"Start Cleaning Table -- on thread: {Environment.CurrentManagedThreadId}");
            Task.Delay(300).Wait();
            Console.WriteLine($"Table ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static void PourWater()
        {
            Console.WriteLine($"Start Pouring Water -- on thread: {Environment.CurrentManagedThreadId}");
            Task.Delay(200).Wait();
            Console.WriteLine($"Water ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static void FryShnitzel()
        {
            Console.WriteLine($"Start Frying Shnitzel -- on thread: {Environment.CurrentManagedThreadId}");
            Task.Delay(2000).Wait();
            Console.WriteLine($"Shnitzel ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static void BoilPotatoes()
        {
            Console.WriteLine($"Start Boiling Potatoes -- on thread: {Environment.CurrentManagedThreadId}");
            Task.Delay(2000).Wait();
            Console.WriteLine($"Potatoes are boiled! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static void MashPotatoes()
        {
            Console.WriteLine($"Start Mashing Potatoes -- on thread: {Environment.CurrentManagedThreadId}");
            Task.Delay(500).Wait();
            Console.WriteLine($"Pure ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }
    }
}
