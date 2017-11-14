using NUnit.Framework;
using System;
using test;
namespace nunittest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(15,15);
        }
    }
}
