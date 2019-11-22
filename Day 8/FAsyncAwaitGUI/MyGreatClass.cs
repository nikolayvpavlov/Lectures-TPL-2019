using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FAsyncAwaitGUI
{
    class MyGreatClass
    {
        private string GetInternal()
        {
            Thread.Sleep(5000);
            return "42";
        }

        public string Get()
        {
            return GetInternal();
        }

        public async Task<string> GetAsync()
        {
            var task = new Task<string>(() => GetInternal());
            task.Start();
            return await task;
        }
    }
}
