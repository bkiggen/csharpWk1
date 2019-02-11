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
            string[] newArray = { "0", "1" };
            Assert.AreEqual(2, Ping.TransformNums(2));
        }
    }
}