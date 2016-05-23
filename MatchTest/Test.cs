using System;
using System.Linq;
using NUnit.Framework;

namespace MatchTest
{
    public class test
    {
        [Test]
        //If incorrect
        public void FalseTest()
        {
            bool results = Match.test("Hi");
            Assert.IsFalse(results);

        }

        [Test]
        //If correct
        public void TrueTest()
        {
            bool results = Match.test("Hello");
            Assert.IsTrue(results);
        }

    }
}