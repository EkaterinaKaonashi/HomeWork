using NUnit.Framework;
using System;

namespace HomeWork.Tests
{
    public class Lesson001Tests
    {

        [TestCase(2, 5, 11)]
        [TestCase(5, 10, 25)]
        public void FirstTaskTest(int a, int b, int expected)
        {
            int actual = Lesson001.FirstTask(a, b);


            Assert.AreEqual(expected, actual);

        }

        [TestCase(2, 5, 15, 5)]
        public void FourthTaskTest(int a, int b, int c, int expected)
        {
            int actual = Lesson001.FourthTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, 7,new int[]{2, 6})]

        public void ThirdTask(int a, int b, int[] expected)
        {
            int[] actual = Lesson001.ThirdTask(a,b);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(6, 8, 12, 6, "2 + x + 6 + y + -60 = 0")]
        [TestCase(11, 21, 61, 8, "13 + x + 50 + y + -1193 = 0")]
        [TestCase(65, 50, 11, 5, "45 + x + -54 + y + -225 = 0")]
        public void FiveTask(int x1, int y1, int x2, int y2, string expected)

        {
            string actual = Lesson001.FiveTask(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10,10)]
        public void FirstTask_WhenBequalsToZero_ShouldException(int a , int b)
        {
            Assert.Throws<DivideByZeroException>(() => Lesson001.FirstTask(a, b));
        }
        [TestCase(30,0)]
        public void ThirdTask_WhenBequalsToZero_ShouldException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Lesson001.ThirdTask(a, b));
        }
        [TestCase(0, 30,15)]
        public static void FourthTask_WhenBequalsToZero_ShouldException(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() => Lesson001.FourthTask(a, b, c));
        }
    }
}