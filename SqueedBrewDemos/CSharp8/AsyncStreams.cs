using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqueedBrewDemos.AsyncStreams
{
    public class AsyncStreams
    {
        public async IAsyncEnumerable<int> CountSomething()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public async Task Consumer()
        {
            await foreach(var number in CountSomething())
            {
                Console.Write(number);
            }
        }
    }
}
