using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class Test
    {
        [Test(Description = "blocking... cook staring")]
        public void Test_SynchronousServing()
        {
            DinnerUtils.ServeDinner();
        }

        [Test(Description = "waiting... cook could do something else in the meantime")]
        public async Task Test_AsynchronousServing()
        {
            await DinnerUtilsAsync.ServeDinner();
        }

        [Test(Description = "two guys making their dinner at the same time")]
        public async Task Test_AsynchronousServing_Many()
        {
            await Task.WhenAll(new List<Task> { DinnerUtilsAsync.ServeDinner(1), DinnerUtilsAsync.ServeDinner(2) });
        }

        [Test(Description = "waiting many operations (tasks) at the same time")]
        public async Task Test_AsynchronousServing_MultitaskingSmartly()
        {
            await DinnerUtilsAsync.ServeDinnerMultitasking();
        }

        [Test(Description = "two guys making their dinner --smartly-- at the same time")]
        public async Task Test_AsynchronousServing_MultitaskingSmartly_Many()
        {
            await Task.WhenAll(new List<Task> { DinnerUtilsAsync.ServeDinnerMultitasking(1), DinnerUtilsAsync.ServeDinnerMultitasking(2) });
        }
    }
}
