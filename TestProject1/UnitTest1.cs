using CSharp.lab1._3;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = Logic.Persent("Буква");
            Assert.That(result.Contains("Букв: 5"));
            Assert.That(result.Contains("Процент букв: 100,00"));
        }

        [Test]
        public void Test2()
        {
            var result = Logic.Persent("Буква 123");
            Assert.That(result.Contains("Букв: 5"));
            Assert.That(result.Contains("Процент букв: 55,56"));
        }

        [Test]
        public void Test3()
        {
            var result = Logic.Persent("123");
            Assert.That(result.Contains("Букв: 0"));
            Assert.That(result.Contains("Процент букв: 0,00"));
        }
    }
}
