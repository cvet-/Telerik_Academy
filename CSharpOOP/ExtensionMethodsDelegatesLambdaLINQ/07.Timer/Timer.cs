using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07.Timer
{
    class Timer
    {
        public delegate void CallbackDelegate();
        public CallbackDelegate Callback;
        private int _secondsUpdateInterval;
        private Thread _timerThread;

        public Timer (int secondsUpdateInterval)
        {
            SecondsUpdateInterval = secondsUpdateInterval;

        }
        private void DoWork()
        {
            Callback();
            Thread.Sleep(SecondsUpdateInterval * 1000);
            if (_timerThread.IsAlive)
            {
                DoWork();
            }
        }
        public void Start()
        {
            _timerThread = new Thread(DoWork);
            _timerThread.Start();
        }
        public void Stop()
        {
            _timerThread.Abort();
        }
        public int SecondsUpdateInterval
        {
            get { return _secondsUpdateInterval; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                _secondsUpdateInterval = value;
            }
        }
    }
}
