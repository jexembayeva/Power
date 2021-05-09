using System;

namespace PowerBase
{
    public class MultiplicationTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToDouble(data[1]);
            double a = Convert.ToDouble(data[0]);
            double q = a * a;
            double p = 1;
            for (int j = 1; j <= n / 2; j++)
            {
                p *= q;
            }

            if (n % 2 != 0)
            {
                p = a * p;
            }

            return p.ToString("0.000000");
        }
    }
}
