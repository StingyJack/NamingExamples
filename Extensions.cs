namespace NamingExamples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class Extensions
    {
        /// <summary>
        ///     Returns null if the string is null or has only whitespace
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string? NullIfWhiteSpace(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }
            return value;
        }
    }
}
