using NUnit.Framework;
using static ×åğíîâèê.Form2;
using static ×åğíîâèê.Form2.PolybiusSquare;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("ÏĞÈÂÅÒ Àíäğåé!!!", "êëş÷");
            Assert.AreEqual("ÛÜÔÍĞŞéËúñıòøäää", result);
        }
        [Test]
        public void Test2()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("ÛÜÔÍĞŞéËúñıòøäää", "êëş÷");
            Assert.AreEqual("ÏĞÈÂÅÒ Àíäğåé!!!", result);
        }
        [Test]
        public void Test3()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("HELLO Amdrey!!!", "key");
            Assert.AreEqual("TQXXaéMzr^ÉÊäää", result);
        }
        [Test]
        public void Test4()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("TQXXaéMzr^ÉÊäää", "key");
            Assert.AreEqual("HELLO Amdrey!!!", result);
        }
        [Test]
        public void Test5()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("?,. (àáâã_", "key");
            Assert.AreEqual("1234567890", result);
        }
        [Test]
        public void Test6()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("1234567890", "key");
            Assert.AreEqual("?,. (àáâã_", result);
        }
        [Test]
        public void Test7()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("one, äâà_ three!÷åòûğå?five)øåñòü.", "key_êëş÷");
            Assert.AreEqual("#@ÅçéñïíÆé<u^ÅÅåÊòAIıòæsvkÅ¸FòÿAJè", result);
        }
        [Test]
        public void Test8()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("#@ÅçéñïíÆé<u^ÅÅåÊòAIıòæsvkÅ¸FòÿAJè", "key_êëş÷");
            Assert.AreEqual("one, äâà_ three!÷åòûğå?five)øåñòü.", result);
        }
    }
}