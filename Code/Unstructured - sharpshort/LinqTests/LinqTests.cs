using Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LinqTests
{
    public class Tests
    {
        readonly int WorkersNum = 10000;
        Dictionary<string, int> staffA;

        [SetUp]
        public void Setup()
        {
            staffA = GenerateRandomStaff.Get(WorkersNum);
        }

        [Test]
        public void SumTest()
        {
            var linqSum = LinqMethods.Sum(staffA);
            var manualSum = ManualMethods.Sum(staffA);

            Assert.IsTrue(linqSum == manualSum);
        }

        [Test]
        public void MinTest()
        {
            var linqMin = LinqMethods.Min(staffA);
            var manualMin = ManualMethods.Min(staffA);

            Assert.IsTrue(linqMin == manualMin);
        }

        [Test]
        public void MaxTest()
        {
            var linqMax = LinqMethods.Max(staffA);
            var manualMax = ManualMethods.Max(staffA);

            Assert.IsTrue(linqMax == manualMax);
        }

        [Test]
        public void AverageTest()
        {
            var linqAverage = LinqMethods.Average(staffA);
            var manualAverage = ManualMethods.Average(staffA);

            // Official MS method (https://docs.microsoft.com/en-us/dotnet/api/system.double.equals?view=net-5.0)
            var difference = Math.Abs(linqAverage * .00001);

            Assert.IsTrue(Math.Abs(linqAverage - manualAverage) <= difference);
        }

        [Test]
        public void CountTest()
        {
            var linqCount = LinqMethods.Count(staffA);
            var manualCount = ManualMethods.Count(staffA);

            Assert.IsTrue(linqCount == manualCount);
        }

        [Test]
        public void LongCountTest()
        {
            var linqLongCount = LinqMethods.LongCount(staffA);
            var manualLongCount = ManualMethods.LongCount(staffA);

            Assert.IsTrue(linqLongCount == manualLongCount);
        }
    }
}
