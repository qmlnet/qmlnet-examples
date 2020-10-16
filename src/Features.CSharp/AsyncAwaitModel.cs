using System;
using System.Threading.Tasks;

namespace Features
{
    public class AsyncAwaitModel
    {
        public async Task<string> RunAsyncTask(string message)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return message;
        }
    }
}