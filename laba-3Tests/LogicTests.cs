using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void UnionTest()
        {
            Set a = new Set("1 2 3");
            Set b = new Set("4 5 6");
            Set result = new Set("1 2 3 4 5 6");
            Assert.AreEqual(result, Logic.GetResult(a, b, "+"));
        }
        [TestMethod()]
        public void Intersect()
        {
            Set a = new Set("1 2 3");
            Set b = new Set("1 4 6");
            Set result = new Set("1");
            Assert.AreEqual(result, Logic.GetResult(a, b, "*"));
        }
        [TestMethod()]
        public void Except()
        {
            Set a = new Set("1 2 3");
            Set b = new Set("3 4 5");
            Set result = new Set("1 2");
            Assert.AreEqual(result, Logic.GetResult(a, b, "-"));
        }
    }
}