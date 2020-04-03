using System;
using DDDSample.Domain.src.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace DDDSampleTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// 例) number=2、separator='='の場合
        /// A=B=C → OK
        /// A=B → NG、区切り文字が足りない
        /// A=B=C=D → NG、区切り文字が多い
        /// A="B=C"=D → OK
        /// A="B""=C"=D →OK
        /// 
        [TestMethod]
        public void Test1()
        {
            "A=B=C".FixedSplit(2, '=').Count().Is(3);
        }

        [TestMethod]
        public void Test2()
        {
            AssertEx.Throws<FormatException>(() => "A=B".FixedSplit(2, '=')).Message.Is("区切り文字が足りない");
        }

        [TestMethod]
        public void Test3()
        {
            AssertEx.Throws<FormatException>(() => "A=B=C=D".FixedSplit(2, '=')).Message.Is("区切り文字が多い");
        }

        [TestMethod]
        public void Test4()
        {
            "A=\"B = C\"=D".FixedSplit(2, '=').Count().Is(3);
        }

        [TestMethod]
        public void Test5()
        {
            "A=\"B\"\" = C\"=D".FixedSplit(2, '=').Count().Is(3);
        }
    }
}
