using MaximumUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumUsingGenericsTest
{
    [TestClass]
    public class UnitTest1
    {
        public void Maximum_Value_First_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(10, 20, 30);
            Assert.AreEqual(30, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_Second_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(30, 20, 10);
            Assert.AreEqual(30, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_Third_Parameter_Should_Return_Maximum_Value()
        {
           
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(20, 10, 30);
            Assert.AreEqual(30, actual);
        }
    }
}
