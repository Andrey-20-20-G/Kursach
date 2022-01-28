using NUnit.Framework;
using static ��������.Form2;
using static ��������.Form2.PolybiusSquare;

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
            var result = tmp.PolibiusEncrypt("������ ������!!!", "����");
            Assert.AreEqual("����������������", result);
        }
        [Test]
        public void Test2()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("����������������", "����");
            Assert.AreEqual("������ ������!!!", result);
        }
        [Test]
        public void Test3()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("HELLO Amdrey!!!", "key");
            Assert.AreEqual("TQXXa�Mzr^�����", result);
        }
        [Test]
        public void Test4()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("TQXXa�Mzr^�����", "key");
            Assert.AreEqual("HELLO Amdrey!!!", result);
        }
        [Test]
        public void Test5()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("?,. (����_", "key");
            Assert.AreEqual("1234567890", result);
        }
        [Test]
        public void Test6()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("1234567890", "key");
            Assert.AreEqual("?,. (����_", result);
        }
        [Test]
        public void Test7()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolibiusEncrypt("one, ���_ three!������?five)�����.", "key_����");
            Assert.AreEqual("#@��������<u^�����AI���svkŸF��AJ�", result);
        }
        [Test]
        public void Test8()
        {
            var tmp = new PolybiusSquare();
            var result = tmp.PolybiusDecrypt("#@��������<u^�����AI���svkŸF��AJ�", "key_����");
            Assert.AreEqual("one, ���_ three!������?five)�����.", result);
        }
    }
}