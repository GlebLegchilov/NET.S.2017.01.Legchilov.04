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
            #region Interface 
        /// <summary>
        /// Create bigger number
        /// </summary>
        /// <param name="strOne">Old number</param>
        /// <returns>New number</returns>
        public static int NextBiggerNumber(int number)
        {
            if (number <= 0)
                throw new ArgumentException();
            return NextBiggerNumberMaster(number);
        }
        #endregion

            #region Logic
        /// <summary>
        /// Create bigger number
        /// </summary>
        /// <param name="strOne">Old number</param>
        /// <returns>New number</returns>
        internal static int NextBiggerNumberMaster(int number)
        {
            var newNumber = number.ToString().OrderByDescending(x => x);
            string tempstr = string.Empty;
            foreach (char item in newNumber)
                tempstr = tempstr + item;
            int result = Int32.Parse(tempstr);
            if (number == result)
                return -1;
            else
                return result;
        }
        #endregion

    }
}
