using AsyncAwait;

Console.WriteLine("Let's serve dinner!");

// Blocking
//DinnerUtils.ServeDinner();

// Awaiting
//await DinnerUtilsAsync.ServeDinner();
// two guys making their dinner at the same time:
//await Task.WhenAll(new List<Task> { DinnerUtilsAsync.ServeDinner(1), DinnerUtilsAsync.ServeDinner(2) });

// Awaiting smartly
//await DinnerUtilsAsync.ServeDinnerMultitasking();
// two guys making their dinner smartly at the same time:
//await Task.WhenAll(new List<Task> { DinnerUtilsAsync.ServeDinnerMultitasking(1), DinnerUtilsAsync.ServeDinnerMultitasking(2) });