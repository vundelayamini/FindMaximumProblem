using MaximumUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumUsingGenericsTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        public void Maximum_Value_First_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            float max = find.MaximumFloatNumber(10.3f, 20.4f, 30.5f);
            Assert.AreEqual(30.5f, max);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_Second_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            float max = find.MaximumFloatNumber(30.5f, 20.4f, 10.3f);
            Assert.AreEqual(30.5f, max);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_Third_Parameter_Should_Return_Maximum_Value()
        {
           
            FindMaximumNum find = new FindMaximumNum();
            float max = find.MaximumFloatNumber(20.4f, 10.3f, 30.5f);
            Assert.AreEqual(30.5f, max);
        }
    }
}
