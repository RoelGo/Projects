using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MultiDimentionalComparison.ArrayComparator;

namespace MultiDimentionalComparison
{
    [TestClass]
    public class MultiDimentionalComparisonTest
    {
        [TestMethod]
        public void NoDifferenceShouldReturnEmptyArray()
        {
            int[,] testArray =
            {
                {4, 2, 5},
                {5, 2, 4},
                {4, 5, 2}
            };

            string expected = new string[3, 3].ToString();
            string actual = Compare(testArray, testArray).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DifferenceShouldReturnStringyArray()
        {
            int[,] testArray =
            {
                {4, 2, 5},
                {5, 2, 4},
                {4, 5, 2}
            };
            int[,] testArray2 =
            {
                {4, 2, 5},
                {5, 3, 4},
                {4, 5, 2}
            };

            string expected = new string[,]
            {
                {null, null, null},
                {null, "2 -- 3", null},
                {null, null, null}
            }.ToString();

            string actual = Compare(testArray, testArray2).ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}