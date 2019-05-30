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
            while (true)
            {
                for (int i = 0; i < m_spinCount; i++)
                {
                    if (m_waitHandler.WaitOne(10))
                    {
                        return;
                    }
                }

                Thread.Sleep(10);
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

            if (timeout == 0)
            {
                for (int i = 0; i < m_spinCount; i++)
                {
                    if (m_waitHandler.WaitOne(10))
                    {
                        return true;
                    }

                    if (start.AddMilliseconds(timeout) <= DateTime.UtcNow)
                    {
                        return false;
                    }
                }

                Thread.Sleep(10);
            }

            while (start.AddMilliseconds(timeout) > DateTime.UtcNow)
            {
                for (int i = 0; i < m_spinCount; i++)
                {
                    if (m_waitHandler.WaitOne(10))
                    {
                        return true;
                    }

                    if (start.AddMilliseconds(timeout) <= DateTime.UtcNow)
                    {
                        return false;
                    }
                }

                Thread.Sleep(10);
            }

            return false;
        }

        public void Dispose()
        {
            m_waitHandler.Dispose();
        }
    }
}
