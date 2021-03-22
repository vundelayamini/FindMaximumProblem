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
            string max = find.MaximumStringNumber(Apple, Banana, Peach);
            Assert.AreEqual(Peach, max);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_Second_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            string max = find.MaximumStringNumber(Apple, Banana, Peach);
            Assert.AreEqual(Peach, max);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_Third_Parameter_Should_Return_Maximum_Value()
        {
           
            FindMaximumNum find = new FindMaximumNum();
            string max = find.MaximumStringNumber(Apple, Banana, Peach);
            Assert.AreEqual(Peach, max);
        }
    }
}
