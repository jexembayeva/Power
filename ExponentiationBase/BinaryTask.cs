using System;
using System.Numerics;

namespace ExponentiationBase
{
    public class BinaryTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt64(data[1]);
            var a = Convert.ToDouble(data[0]);
            return Power(a, n).ToString("0.000000");
        }

        static double Power(double x, long n)
        {
            if (n == 0)
            {
                return 1;
            }

            if ((n & 1) == 0)
            {
                var p = Power(x, n >> 1);
                return p * p;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }
    }
}
