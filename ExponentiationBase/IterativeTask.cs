
using System;

namespace ExponentiationBase
{
    public class IterativeTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToDouble(data[1]);
            double a = Convert.ToDouble(data[0]);
            double p = 1.0d;

            for (int j = 1; j <= n; j++)
            {
                p *= a;
            }
            return p.ToString("0.000000");
        }
    }
}
