using System;
using System.Collections.Generic;

namespace Linq
{
    public static partial class ManualMethods
    {
        public static long Sum(Dictionary<string, int> staff)
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

            return sum;
        }
    }
}
