using System;
using System.Linq;


[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Task3Test")]
namespace Task3
{
    /// <summary>
    /// Class create bigger number
    /// </summary>
    public static class BiggerNumber
    {
        /// <summary>
        /// Create bigger number
        /// </summary>
        /// <param name="number">Old number</param>
        /// <returns>New number</returns>
        public static int NextBiggerNumber(int number)
        {
            if (number <= 0)
                throw new ArgumentException(nameof(number));
            var newNumber = number.ToString().OrderByDescending(x => x);
            string tempstr = string.Empty;
            foreach (char item in newNumber)
                tempstr += item;
            int result = int.Parse(tempstr);
            if (number == result) return -1;
            return result;
        }
    }
}
