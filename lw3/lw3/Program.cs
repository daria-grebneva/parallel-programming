using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lw3
{
    class Program
    {
        static void Info()
        {
            Console.WriteLine("dotnet lw3.dll <iterations> <timeout> <spinCount>");
        }

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Info();
                return;
            }

            int iterations = Convert.ToInt32(args[0]);
            int timeout = Convert.ToInt32(args[1]);
            int spinCount = Convert.ToInt32(args[2]);

            if (iterations.Equals(null) || timeout.Equals(null) || spinCount.Equals(null))
            {
                Info();
                return;
            }

            PiCalculator piCalculator = new PiCalculator(iterations, timeout, spinCount, "Enter");
            Stopwatch watch = Stopwatch.StartNew();
            double pi = piCalculator.CalculatePi();
            watch.Stop();

            Console.WriteLine($"Pi = {pi} time = {watch.ElapsedMilliseconds}ms type - Enter");
            piCalculator = new PiCalculator(iterations, timeout, spinCount, "TryEnter");
            watch = Stopwatch.StartNew();
            pi = piCalculator.CalculatePi();
            watch.Stop();
            Console.WriteLine($"Pi = {pi} time = {watch.ElapsedMilliseconds}ms type - TryEnter");
          
        }
    }
}
