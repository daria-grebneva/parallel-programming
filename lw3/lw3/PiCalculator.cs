using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lw3
{
    public class ArgsThread
    {
        public long m_left;
        public long m_right;
        public double m_step;
        public Action m_enter;
        public Action m_leave;

        public ArgsThread(long left, long right, double step, Action enter, Action leave)
        {
            m_left = left;
            m_right = right;
            m_step = step;
            m_enter = enter;
            m_leave = leave;
        }
    }

    class PiCalculator
    {
        private const int THREADS_COUNT = 4;

        private static double m_pi = 0;

        private int m_iterations;
        private int m_timeout;
        private string m_enterMethod;
        private ICriticalSection m_criticalSection;

        public PiCalculator(int iterations, int timeout, int spinsCount, string enterMethod)
        {
            m_iterations = iterations;
            m_timeout = timeout;
            m_enterMethod = enterMethod;
            m_criticalSection = new AutoResetEventMethod();
            m_criticalSection.SetSpinCount(spinsCount);
        }

        public double CalculatePi()
        {
            m_pi = 0;
            Action enter = () => m_criticalSection.Enter();
            void leave() => m_criticalSection.Leave();

            if (m_enterMethod == "TryEnter")
            {
                enter = () => {
                    while (!m_criticalSection.TryEnter(m_timeout)) { }
                };
            }

            var workers = new List<Thread>();

            int stepsCountPerThread = m_iterations / THREADS_COUNT;
            double step = 1.0 / m_iterations;
            for (int i = 0; i < THREADS_COUNT; i++)
            {
                var newThread = new Thread(Worker);
                newThread.Start(new ArgsThread (i * stepsCountPerThread, (i + 1) * stepsCountPerThread, step, enter, leave));

                workers.Add(newThread);
            }

            foreach (Thread worker in workers)
            {
                worker.Join();
            }

            return m_pi;
        }

        private static void Worker(object argsThread)
        {
            var argsThreadValue = (ArgsThread)argsThread;
            for (long i = argsThreadValue.m_left; i < argsThreadValue.m_right; i++)
            {
                var x = (i + 0.5) * argsThreadValue.m_step;
                var sum = 4.0 / (1.0 + x * x);

                argsThreadValue.m_enter();
                m_pi += sum * argsThreadValue.m_step;
                argsThreadValue.m_leave();
            }
        }
    }
}
