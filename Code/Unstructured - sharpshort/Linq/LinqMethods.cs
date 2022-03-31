using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class LinqMethods
    {
        // Average
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Average.cs
        public static double Average(Dictionary<string, int> staff) => staff.Values.Average();

        // Sum
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Sum.cs
        public static long Sum(Dictionary<string, int> staff) => staff.Values.Sum();

        // Min
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Min.cs
        public static int Min(Dictionary<string, int> staff) => staff.Values.Min();

        // Max
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Max.cs
        public static int Max(Dictionary<string, int> staff) => staff.Values.Max();

        // Count
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available")]
        public static int Count(Dictionary<string, int> staff) => staff.Count();

        // LongCount
        // github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available")]
        public static long LongCount(Dictionary<string, int> staff) => staff.LongCount();
    }
}
