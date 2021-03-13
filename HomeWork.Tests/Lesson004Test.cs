using NUnit.Framework;
namespace HomeWork.Tests
{
    public class Lesson004Test
    {

        [TestCase(new int[] { 3, 6, 1 }, 1)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, -3)]
        [TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, -6)]

        public void FirstTaskTest(int[] ar, int expected)
        {
            int actual = Lesson004.FirstTask(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, 6)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, 7)]
        [TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, 37)]

        public void SecondTaskTest(int[] array, int expected)
        {
            int actual = Lesson004.SecondTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, 2)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, 4)]
        [TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, 5)]

        public void ThirdTaskTest(int[] array, int expected)
        {
            int actual = Lesson004.ThirdTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, 1)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, 3)]
        [TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, 2)]

        public void FourthTask(int[] array, int expected)
        {
            int actual = Lesson004.FourthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, 6)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, 9)]
        [TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, 0)]


        public void FifthTaskTest(int[] array, int expected)
        {
            int actual = Lesson004.FifthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, new int [] {1, 6, 3})]
        [TestCase(new int[] { 9,4,2,7,2,7}, new int[] { 7, 2, 7, 2, 4, 9 })]
        [TestCase(new int[] { 2,1}, new int[] { 1, 2 })]

        public void SixthTask(int[] array,int[] expected)
        {
            int[] actual = Lesson004.SixthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 6, 1 }, 2)]
        [TestCase(new int[] { 5, 2, 5, 7, -3 }, 4)]
        //[TestCase(new int[] { 7, 4, 37, 2, 7, -6, -4 }, 4)] надо подумать , как обойти четное число с - 

        public void SeventhTaskTest(int[] array,int expected)
        {
            int actual = Lesson004.SeventhTask(array);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1 ,2 })]
        [TestCase(new int[] { 1,2,3,4,5 }, new int[] { 4,5,3,1,2 })]

        public void EighthTaskTest(int[] array,int[] expected)
        {
            int[] actual = Lesson004.EighthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {4,7,3,1,7} ,new int[] {1,3,4,7,7})]
        [TestCase(new int[] {4,5,2,7,9,0,3,8,2}, new int[] {0,2,2,3,4,5,7,8,9})]

        public void BubbleSortTest(int[] array,int[] expected)
        {
            int[] actual = Lesson004.BubbleSort(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {1,2,3,4,5}, new int[] {5,4,3,2,1})]
        [TestCase(new int[] {0,4,5,2,6}, new int[] {6,5,4,2,0})]
        public void InsertSortTest(int[] array, int[] expected)
        {
            int[] actual = Lesson004.InsertSort(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
