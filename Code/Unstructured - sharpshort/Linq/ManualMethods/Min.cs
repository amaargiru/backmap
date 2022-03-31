using System;
using System.Collections.Generic;

namespace Linq
{
    public static partial class ManualMethods
    {
        public static int Min(Dictionary<string, int> staff)
        {
            if (staff is null)
            {
                throw new ArgumentNullException(nameof(staff));
            }

            int min = int.MaxValue;

            checked
            {
                foreach (var worker in staff)
                {
                    if (worker.Value < min)
                    {
                        min = worker.Value;
                    }
                }
            }

            return min;
        }
    }
}
