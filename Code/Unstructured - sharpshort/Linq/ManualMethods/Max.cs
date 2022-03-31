using System;
using System.Collections.Generic;

namespace Linq
{
    public static partial class ManualMethods
    {
        public static int Max(Dictionary<string, int> staff)
        {
            if (staff is null)
            {
                throw new ArgumentNullException(nameof(staff));
            }

            int max = int.MinValue;

            checked
            {
                foreach (var worker in staff)
                {
                    if (worker.Value > max)
                    {
                        max = worker.Value;
                    }
                }
            }

            return max;
        }
    }
}
