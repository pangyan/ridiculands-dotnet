using NUnit.Framework;
using System.IO;
using System;
using xUnitTestPyWong;

namespace HelloWorldTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            myClass.dnlm();
            Assert.That(() => myClass.getA(), Is.EqualTo(Expected).After(10).Seconds.PollEvery(250).MilliSeconds);
        }
    }
}