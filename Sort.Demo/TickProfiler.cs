using System.Diagnostics;

namespace Sort.Demo
{
    internal class TickProfiler
    {
        private readonly Stopwatch _stopwatch;

        public TickProfiler()
        {
            _stopwatch = new Stopwatch();
        }

        public void Start()
        {
            if (_stopwatch.IsRunning)
            {
                Stop();
            }

            _stopwatch.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
            _stopwatch.Reset();
        }

        public long GetMilliseconds()
        {
            return _stopwatch.ElapsedMilliseconds;
        }
    }
}
