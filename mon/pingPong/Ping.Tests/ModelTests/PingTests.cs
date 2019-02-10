using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;


namespace PingPong.TestTools
{
    [TestClass]
    public class PingTest
    {
        [TestMethod]
        public void TransformNums_Number_True()
        {
            Ping testPing = new Ping();
            Assert.AreEqual(2, testPing.TransformNums(2));
        }
    }
}