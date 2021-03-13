using System;
using NUnit.Framework;
namespace HomeWork.Tests
{
    public class Lesson005Test
    {
        [TestCase(1,0)]
        [TestCase(2, 1)]
        [TestCase(3, 3)]

        public void FirstTaskTestTest(int mockNumber   ,int expected)
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int actual = Lesson005.FirstTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 74)]
        [TestCase(3, 9)]

        public void SecondTaskTest(int mockNumber, int expected)
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int actual = Lesson005.SecondTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {1,3})]
        [TestCase(2, new int[] { 1, 4 })]
        [TestCase(3, new int[] { 0, 2 })]

        public void ThirdTaskTest(int mockNumber, int[] expected)
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int[] actual = Lesson005.ThirdTask(array);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, new int[] { 2, 1 })]
        [TestCase(2, new int[] { 1, 3 })]
        [TestCase(3, new int[] { 0, 0 })]
     
        public void FouthTaskTest(int mocNumber,int[] expected)
        {
            int[,] array = Lesson005Mock.GetMock(mocNumber);
            int[] actual = Lesson005.FouthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,4 )]
        [TestCase(2, 5)]
        [TestCase(3, 3)]

        public void FivethTaskTest(int mockNumber, int expected)
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int actual = Lesson005.FivethTask(array);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(1)]
        
        public void SixthTaskTest(int mockNumber )
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int[,] actual = Lesson005.SixthTask(array);
            int[,] expected = new int[,]
            {
                {1,5,4,3 },
                {4,2,9,1 },
                {6,8,0,5 },
                {2,0,5,6 }
            };
            Assert.AreEqual(expected, actual);
            
        }

        [TestCase(3)]
        public void SixthTaskTest2(int mockNumber)
        {
            int[,] array = Lesson005Mock.GetMock(mockNumber);
            int[,] actual = Lesson005.SixthTask(array);
            int[,] expected = new int[,]
            {
                {9,3 },
                {5,6 },
                {3,5 },
                {6,3 }
            };
            Assert.AreEqual(expected, actual);
        }
    }

    public static class Lesson005Mock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int [0, 0];

            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        {1,4,6,2 },
                        {5,2,8,0 },
                        {4,9,0,5 },
                        {3,1,5,6 }
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        {4,7,9,2,53 },
                        {41,4,5,74,1 },
                        {4,1,53,6,1 }
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                        {9,5,3,6 },
                        {3,6,5,3 }
                    };
                    break;
            }

            return result;
        }
    }
}
