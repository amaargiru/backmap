using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Linq;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class LinqVsManual
    {
        private Dictionary<string, int> _staffA = new();

        [Params(1_000, 10_000, 100_000)]
        public int WorkersNum { get; set; }

        [GlobalSetup]
        public void Setup() => _staffA = GenerateRandomStaff.Get(WorkersNum);

        [Benchmark]
        public double ManualAverage() => ManualMethods.Average(_staffA);

        [Benchmark]
        public double LinqAverage() => LinqMethods.Average(_staffA);

        [Benchmark]
        public long ManualSum() => ManualMethods.Sum(_staffA);

        [Benchmark]
        public long LinqSum() => LinqMethods.Sum(_staffA);

        [Benchmark]
        public int ManualMin() => ManualMethods.Min(_staffA);

        [Benchmark]
        public int LinqMin() => LinqMethods.Min(_staffA);

        [Benchmark]
        public int ManualMax() => ManualMethods.Max(_staffA);

        [Benchmark]
        public int LinqMax() => LinqMethods.Max(_staffA);

        [Benchmark]
        public int ManualCount() => ManualMethods.Count(_staffA);

        [Benchmark]
        public int LinqCount() => LinqMethods.Count(_staffA);

        [Benchmark]
        public long ManualLongCount() => ManualMethods.LongCount(_staffA);

        [Benchmark]
        public long LinqLongCount() => LinqMethods.LongCount(_staffA);
    }

    internal class LinqBenchmarks
    {
        private static void Main()
        {
            BenchmarkRunner.Run<LinqVsManual>();
            Console.ReadKey();
        }
    }
}