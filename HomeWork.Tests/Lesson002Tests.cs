using NUnit.Framework;

namespace HomeWork.Tests
{
    public class Lesson002Tests
    {

        [TestCase(13, 6, 19)]
        [TestCase(3, 3, 9)]
        [TestCase(6, 18, -12)]
        public void FirstTaskTest(int a, int b, int expected)
        {
            int actual = Lesson002.FirstTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 7, "Это первая четверть")]
        [TestCase(-3, 6, "Это вторая четверть")]
        [TestCase(-3, -12, "Это третья четверть")]
        [TestCase(5, -10, "Это четвертая четверть")]
        [TestCase(0, 0, "точка лежит на плоскости")]

        public void SecondTaskTest(int x, int y, string expected)
        {
            string actual = Lesson002.SecondTask(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 3, 21, new int[] { 3, 8, 21 })]
        [TestCase(98, 212, 71, new int[] { 71, 98, 212 })]
        [TestCase(31, 0, -45, new int[] { -45, 0, 31 })]

        public void ThirdTask(int a, int b, int c, int[] expected)
        {
            int[] actual = Lesson002.ThirdTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(10, 6, 3, new double[] {3,2})] выбрасывает исключение, которое прописали
        [TestCase(2, 5, -7, new double[] { 1, -3.5})]
        [TestCase(1, -4, 4, new double[] { 2,0})] // если указать без 0, то будет ошибка
        public void FourthTaskTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Lesson002.FourthTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(21,"двадцать один")]
        [TestCase(19, "девятнадцать ")]
        [TestCase(10, "десять ")]
        [TestCase(90, "девяносто ")]
        public void FifthTaskTest(int number, string expected)
        {
            string actual = Lesson002.FifthTask(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
