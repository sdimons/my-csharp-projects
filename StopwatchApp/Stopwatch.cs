using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchApp
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public TimeSpan Duration
        {
            get
            {
                return _endTime - _startTime;
            }
        }
        
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is running!");

            _isRunning = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running!");
            _endTime = DateTime.Now;
            _isRunning = false;
        }
    }
}
