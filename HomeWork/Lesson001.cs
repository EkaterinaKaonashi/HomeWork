using System;

namespace HomeWork
{
    public class Lesson001
    {

        public static double FirstTask(double a,double b)
        {
            double result = ((5 * a) + (b * b)) / (b - a);

            return result;

            
        }

        public static void SecondTask()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }

        public static void ThirdTask()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            int remainder = a % b;

            Console.WriteLine($"Рузультат = {result} " + $" Остаток от деления = {remainder}");
        }

        public static void FourthTask()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x = (c - b) / a;

            Console.WriteLine("Найти переменную Х в: A * X + B = C ");

            
            

            Console.WriteLine(x);
        }

        public static void FiveTask()
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            int a = y1-y2;
            int b = x2 - x1;
            int c = x1 * y2 - x2 * y1;
            if(c > 0)
            {
                Console.WriteLine(a + "x+" + b + "y+" + c + "=0");
            }
            else
            {
                Console.WriteLine(a + "x+" + b + "y" + c + "=0");
            }
            
        }
    }
}
