using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        int a = 20;

        [TestMethod]
        public void SampleMethod1()
        {
            Assert.AreEqual(a, 20);  
        }

        [TestMethod]
        public void SampleMethod2()
        {
            Assert.IsTrue(a < 100);  
        }
    }
}
