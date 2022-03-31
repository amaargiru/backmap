using System;
using System.Collections.Generic;

namespace Linq
{
    public static partial class ManualMethods
    {
        public static int Count(Dictionary<string, int> staff)
        {
            if (staff is null)
            {
                throw new ArgumentNullException(nameof(staff));
            }

            int count = 0;

            checked
            {
                foreach (var worker in staff)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
