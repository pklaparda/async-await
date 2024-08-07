using System.Diagnostics;

namespace AsyncAwait
{
    public static class DinnerUtilsAsync
    {
        // yep, you're still waiting on each operation... but you have someone else that can serve dinner at the same time.
        public static async Task ServeDinner(int cook = 1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            await CleanTable();
            await FryShnitzel();
            await BoilPotatoes();
            await PourWater();
            Console.WriteLine($"Cook {cook}, Serving dinner took: " + sw.ElapsedMilliseconds + " ms");
        }

        private static async Task CleanTable()
        {
            Console.WriteLine($"Start Cleaning Table -- on thread: {Environment.CurrentManagedThreadId}");
            await Task.Delay(300);
            Console.WriteLine($"Table ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static async Task PourWater()
        {
            Console.WriteLine($"Start Pouring Water -- on thread: {Environment.CurrentManagedThreadId}");
            await Task.Delay(200);
            Console.WriteLine($"Water ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static async Task FryShnitzel()
        {
            Console.WriteLine($"Start Frying Shnitzel -- on thread: {Environment.CurrentManagedThreadId}");
            await Task.Delay(2000);
            Console.WriteLine($"Shnitzel ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        private static async Task BoilPotatoes()
        {
            Console.WriteLine($"Start Boiling Potatoes -- on thread: {Environment.CurrentManagedThreadId}");
            await Task.Delay(2000);
            Console.WriteLine($"Potatoes are Boiled! -- on thread: {Environment.CurrentManagedThreadId}");
            await MashPotatoes();
        }

        private static async Task MashPotatoes()
        {
            Console.WriteLine($"Start Mashing Potatoes -- on thread: {Environment.CurrentManagedThreadId}");
            await Task.Delay(500);
            Console.WriteLine($"Pure ready! -- on thread: {Environment.CurrentManagedThreadId}");
        }

        public static async Task ServeDinnerMultitasking(int cook = 1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tasks = new List<Task> { BoilPotatoes(), FryShnitzel() }; // start preparing hot food
            await CleanTable();
            await PourWater();
            await Task.WhenAll(tasks); // serve when ready so it doent's get cold
            Console.WriteLine($"Cook {cook}, Serving dinner took: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
