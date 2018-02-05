using System;
using MDIFormDenemesi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test1 t = new Test1();
            int input = t.FiyatDogruMu("123");
            Assert.AreEqual(1, input);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Test1 t = new Test1();
            int input = t.FiyatDogruMu(" ");
            Assert.AreEqual(0, input);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Test1 t = new Test1();
            int input = t.FiyatDogruMu("abc");
            Assert.AreEqual(2, input);

        }
    }
    

}
