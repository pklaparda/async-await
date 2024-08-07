using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {

        public MyClass() // constructor
        {
            LoadFromHttp().Await(Completed, Failure);
        }

        public virtual async Task LoadFromHttp() // async method
        {
            var httpClient = new HttpClient();
            throw new Exception("boom");
            await httpClient.GetStringAsync("http://google.com");
            await Task.Delay(2000);
        }

        public void Completed() => Console.WriteLine("loaded");
        public void Failure(Exception ex) => Console.WriteLine(ex.ToString());
    }
}
