using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatchTest.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        //If incorrect
        public void FalseTest()
        {
            bool results = Match.test("Hi");
            Assert.IsFalse(results);

        }

        [TestMethod]
        //If correct
        public void TrueTest()
        {
            bool results = Match.test("Hello");
            Assert.IsTrue(results);
        }

    }
}

