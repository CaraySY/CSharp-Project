using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreDemo.Threading
{
    public class Worker
    {
        private volatile bool _shouldStop;

        public void DoWork()
        {
            bool work = false;
            while (!_shouldStop)
            {
                work = !work;
            }
            Console.WriteLine("Worker thread: terminating gracefully.");
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }
    }
}
