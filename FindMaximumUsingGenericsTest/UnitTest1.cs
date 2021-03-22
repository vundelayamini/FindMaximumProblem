using MaximumUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumUsingGenericsTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            int[] intArray = { 10, 20, 30 };
            FindMax<int> first = new FindMax<int>(intArray);
            int actual = first.FindMaxValue();
            Assert.AreEqual(30, actual);
        }
        //TC1.2
        [TestMethod]
        public void Passing_Float_Array_Should_Return_Maximum_Value()
        {
            float[] floatArray = { 10.3f, 20.4f, 30.5f };
            FindMax<float> secod = new FindMax<float>(floatArray);
            float actual = secod.FindMaxValue();
            Assert.AreEqual(30.5f, actual);
        }
        //TC1.3
        [TestMethod]
        public void Passing_String_Array_Should_Return_Maximum_Value()
        {

            string[] strArray = { "10", "20", "30" };
            FindMax<string> third = new FindMax<string>(strArray);
            string actual = third.FindMaxValue();
            Assert.AreEqual(30, actual);
        }
    }
}
