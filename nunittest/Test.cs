using NUnit.Framework;
using System;
using test;
namespace nunittest
{
    [TestFixture()]
    public class MainClass
    {
        [Test()]
        public void Hello()
        {
            Assert.AreEqual(15,15);
        }
    }
}
