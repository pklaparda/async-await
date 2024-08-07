using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiLegacy.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/values/noConfigureAwait")]
        public string GetNoCA()
        {
            Console.WriteLine($"current thread: {JsonConvert.SerializeObject(SynchronizationContext.Current)}");
            GetDummyHttpNoCA().GetAwaiter().GetResult();
            return "הכל בסדר";
        }

        [Route("api/values/nonBlockingNoConfigureAwait")]
        public async Task<string> GetNoNoCA()
        {
            Console.WriteLine($"current thread: {JsonConvert.SerializeObject(SynchronizationContext.Current)}");
            await GetDummyHttpNoCA();
            return "הכל בסדר";
        }

        private async Task GetDummyHttpNoCA()
        {
            var httpClient = new HttpClient();
            var res = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
            // the synchronizationContext does only allow ONE thread in at a time
            // httpClient.GetAsync() is in fact returning an uncompleted Task. 
            // the context is captured in the await and will be used to continue running the GetAsync() method later.
            // at the moment GetAsync() is not completed...and the caller is blocking the context thread
            // anytime soon, GetAsync() will get the response and the task will be completed
            // next step is ready to print the response content... but it's waiting for the context to ve available
            // deadlock. GetDummyHttpNoCA() call is blocking the context thread and here after GetAsync() we cannot continue without the context.
            Console.WriteLine(res.Content);
        }

        public string Get()
        {
            Console.WriteLine($"current thread: {JsonConvert.SerializeObject(SynchronizationContext.Current)}");
            GetDummyHttp().GetAwaiter().GetResult();
            return "הכל בסדר";
        }

        [Route("api/values/NonBlockingAndConfigureAwait")]
        public async Task<string> GetNo()
        {
            Console.WriteLine($"current thread: {JsonConvert.SerializeObject(SynchronizationContext.Current)}");
            await GetDummyHttp();
            return "הכל בסדר";
        }

        private async Task GetDummyHttp()
        {
            var httpClient = new HttpClient();
            var res = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1").ConfigureAwait(false);
            // the solution for the above problem is to indicate that once the task is completed it should continue in a ThreadPool thread and not the caller context.
            var obj = await res.Content.ReadAsStringAsync();
            Console.WriteLine(obj);
        }

    }
}
