using System;
using System.Collections.Generic;
using System.IO;

namespace Linq
{
    public static class GenerateRandomStaff
    {
        private static readonly Random random = new();
        const int minOvertime = -10;
        const int maxOvertime = 100;

        public static Dictionary<string, int> Get(int workersNum)
        {
            Dictionary<string, int> staff = new();

            while (staff.Count < workersNum)
            {
                var workerName = Path.GetRandomFileName()[..3];
                var workerOvertime = random.Next(minOvertime, maxOvertime);

                staff[workerName] = workerOvertime;
            }

            return staff;
        }
    }
}
