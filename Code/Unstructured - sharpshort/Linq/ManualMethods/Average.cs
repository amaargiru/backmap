// ReSharper disable ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
using System;
using System.Collections.Generic;

namespace Linq
{
    public static partial class ManualMethods
    {
        public static double Average(Dictionary<string, int> staff)
        {
            if (staff is null)
            {
                throw new ArgumentNullException(nameof(staff));
            }

            long sum = 0;

            checked
            {
                foreach (var worker in staff)
                {
                    sum += worker.Value;
                }
            }

            return (double) sum / staff.Count;
        }
    }
}
