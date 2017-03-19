using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    /// <summary>
    /// Class find root by the Niyton method
    /// </summary>
    public static class FindRoot
    {
        #region Interface
        /// <summary>
        /// Find root by the Newton's method 
        /// </summary>
        /// <param name="x">Number</param>
        /// <param name="power">Root's power</param>
        /// <param name="e">Accuracy</param> 
        /// <returns>Number's root</returns>
        public static double Find(double x, int power, double e = 0.0001)
        {
            if (power < 0)
                throw new ArgumentException();
            return FindMaster(x, power, e);
        }
        #endregion

        #region logic
        /// <summary>
        /// Find root by the Newton's method
        /// </summary>
        /// <param name="x">Number</param>
        /// <param name="power">Root's power</param>
        /// <param name="e">Accuracy</param>
        /// <returns>Number's root</returns>
        public static double FindMaster(double x, int power, double e)
        {
            double x1 = x/power;
            double x2 = (1 / (double)power) * ((power - 1) * x1 + x / Math.Pow(x1, power - 1));
            while (Math.Abs(x2 - x1) > e)
            {
                x1 = x2;
                x2 = (1 / (double)power) * ((power - 1) * x1 + x / Math.Pow(x1, power - 1));
            }
            return x2;
        }
        #endregion
    }
}
