using System;

namespace ExponentiationBase
{
    public class MultiplicationTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToDouble(data[1]) / 2;
            double a = Convert.ToDouble(data[0]);
            double p = 1;
            for (int j = 1; j <= n; j++)
            {
                p *= a;
            }

            double res = p * p;
            return res.ToString("0.000000");
        }
    }
}
