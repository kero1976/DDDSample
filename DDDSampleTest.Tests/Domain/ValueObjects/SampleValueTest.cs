using System;
using DDDSample.Domain.src.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDSampleTest.Tests.Domain.ValueObjects
{
    [TestClass]
    public class SampleValueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SampleValue obj1 = new SampleValue("1");
            SampleValue obj2 = new SampleValue("1");

        }
    }
}
