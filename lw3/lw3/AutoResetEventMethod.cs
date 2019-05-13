using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lw3
{
    class AutoResetEventMethod : ICriticalSection, IDisposable
    {
        private int m_spinCount = 1;
        private AutoResetEvent m_waitHandler = new AutoResetEvent(true);

        public void Enter()
        {
            bool isEntered = false;

            for (int i = 0; i < m_spinCount; i++)
            {
                if (m_waitHandler.WaitOne(10))
                {
                    isEntered = true;
                    break;
                }
            }

            if (!isEntered)
            {
                Thread.Sleep(10); 
                m_waitHandler.WaitOne();
            }
        }

        public void Leave()
        {
            m_waitHandler.Set();
        }

        public void SetSpinCount(int count)
        {
            m_spinCount = count;
        }

        public bool TryEnter(int timeout)
        {
            var start = DateTime.UtcNow;
            var isEntered = false;

            for (int i = 0; i < m_spinCount; i++)
            {
                if (m_waitHandler.WaitOne(10))
                {
                    isEntered = true;
                    break;
                }

                if (start.AddMilliseconds(timeout) <= DateTime.UtcNow)
                {
                    break;
                }
            }

            if (!isEntered)
            {
                Thread.Sleep(10);
            }

            return isEntered;
        }

        public void Dispose()
        {
            m_waitHandler.Dispose();
        }
    }
}
