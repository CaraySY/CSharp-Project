using NUnit.Framework;

namespace NUnitTestProject2
{
    [TestFixture]
    public class Tests
    {
        private Calculator cal = null;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Test1()
        {
            int result = cal.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}