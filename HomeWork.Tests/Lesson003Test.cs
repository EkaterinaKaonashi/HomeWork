using NUnit.Framework;
using System;

namespace HomeWork.Tests
{
    public class Lesson003Test
    {

        [TestCase(2,4,16)]
        [TestCase(6, 2, 36)]
        [TestCase(3, 2, 9)]
        public void FirstTaskTest(int a, int b, int expected)
        {
            int actual = Lesson003.FirstTask(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(350 , new int[] {350,700})]
        [TestCase(100, new int[] {100, 200,300,400,500,600,700,800,900,1000})]
        [TestCase(333, new int[] { 333, 666,999 })]

        public void SecondTask(int a,int[] expected)
        {
            int[] actual = Lesson003.SecondTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9,2)]
        [TestCase(16, 3)]
        [TestCase(41, 6)]

        public void ThirdTaskTest(int a,int expected)
        {
            int actual = Lesson003.ThirdTask(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15,5)]
        [TestCase(641, 1)]
        [TestCase(550, 275)]

        public void FourthTask(int a, int expected)
        {
            int actual = Lesson003.FourthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,21,42)]
        [TestCase(-7, 21, 35)]
        public void FifthTask(int a, int b, int expected)
        {
            int actual = Lesson003.FifthTask(a, b);
            Assert.AreEqual(expected, actual);

        }

        
        [TestCase(6, new int[] { 1, 1, 2, 3, 5, 8 })]
        [TestCase(21, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 })]
        [TestCase(3, new int[] { 1, 1, 2 })]

        public void SixthTaskTest(int n, int[] expected)
        {
            int[] actual = Lesson003.SixthTask(n);
            Assert.AreEqual(expected, actual);

        }
        
       

        [TestCase(21,63,21)]
        [TestCase(6, 3, 3)]
        [TestCase(653,4146, 1)]

        public void SeventhTaskTest(int a, int b, int expected)
        {
            int actual = Lesson003.SeventhTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8,2)]
        [TestCase(64, 4)]
        [TestCase(512, 8)]


        public void EighthTaskTest(int number,int expected)
        {
            int actual = Lesson003.EighthTask(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2)]
        [TestCase(8, 4)]
        [TestCase(654, 327)]

        public void NinthTaskTest(int a,int expected)
        {
            int actual = Lesson003.NinthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(321,123)]
        [TestCase(3653, 3563)]
        [TestCase(965314, 413569)]

        public void TenthTaskTest(int num,int expected)
        {
            int actual = Lesson003.TenthTask(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("264338", new int[] {2,6,4,8})]
        [TestCase("52253864624", new int[] { 2,2,8,6,4,6,2,4 })]

        public void EleventhTaskTest(string n, int[] expected) 
        {
            int[] actual = Lesson003.EleventhTask(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("2341","44123", "ДА" )]
        [TestCase("12134241341", "000234141464123", "ДА")]
        [TestCase("006601", "2323232", "Нет")]

        public void TwelfthTest(string n1, string n2,string expected)
        {
            string actual = Lesson003.Twelfth(n1, n2);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(0)]
        public void SecondTask_WhenAequal0_shouldException(int a)
        {
            Assert.Throws<ArgumentException>(() => Lesson003.SecondTask(a));
        }

        [TestCase(0)]
        public void SixthTask_WhenNequalZero_ShouldException (int n)
        {
            Assert.Throws<Exception>(() => Lesson003.SixthTask(n));
        }

    }
}
