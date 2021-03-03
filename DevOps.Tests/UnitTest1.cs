using NUnit.Framework;


namespace DevOps.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.Addition(a, b);
            Assert.AreEqual(6, result);
        }
    }
}