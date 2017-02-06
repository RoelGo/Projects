using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab9
{
    [TestClass]
    public class PairFinderTest
    {
        [TestMethod]
        public void FindPairsInEmptyArrayShouldReturnEmpty()
        {
            int[] testArray = new int[1];

            var expected = false;
            var actual = PairFinder.FindPairs(testArray,1).Any();

            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void FindPairsInArrayShouldRetrunTheRightPairsShort()
        {
            int[] testArray = new int[] {5, 4, 6};

            var expected = new List<Tuple<int,int>>()
            {
                new Tuple<int, int>(5, 4)
            };

            var actual = PairFinder.FindPairs(testArray, 9);

            CollectionAssert.AreEqual(expected, actual);
        }

                [TestMethod]
                public void FindPairsInArrayShouldRetrunTheRightPairsLong()
                {
                    int[] testArray = new int[] {5, 4, 6, 21, 3, 4, 8, 1, 23, 85, 54};
        
                    var expected = new List<Tuple<int, int>>()
                    {
                       new Tuple<int, int>(5, 4),
                       new Tuple<int, int>(5, 4),
                       new Tuple<int, int>(6, 3),
                       new Tuple<int, int>(8, 1)
            
                    };
                    var actual = PairFinder.FindPairs(testArray, 9);
        
        
                    CollectionAssert.AreEqual(expected, actual);
                }
    }
}