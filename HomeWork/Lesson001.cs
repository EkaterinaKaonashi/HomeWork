using System;

namespace HomeWork
{
    public class Lesson001
    {

        public static int FirstTask(int a,int b)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль решение
            if( a == b)
            {
                throw new DivideByZeroException();
            }
            int result = ((5 * a) + (b * b)) / (b - a);

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

        public static int[] ThirdTask(int a ,int b)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.

            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            int result = a / b;

            int remainder = a % b;
            int[] array = new int[2];
            array[0] = result;
            array[1] = remainder;

            return  array;

            //Console.WriteLine($"Рузультат = {result} " + $" Остаток от деления = {remainder}");
        }

        public static int FourthTask(int a, int b,int c)

        {
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.

            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            int x = (c - b) / a;

            Console.WriteLine("Найти переменную Х в: A * X + B = C ");

            return x;
        }

        public static string FiveTask(int x1,int y1, int x2 , int y2)
        {
            

            int a = y1-y2;
            int b = x2 - x1;
            int c = x1 * y2 - x2 * y1;
            string result = "";
            if(c > 0)
            {
                result = $"{a} + x + {b} + y + {c} = 0";
                
            }
            else
            {
                result = $"{a} + x + {b} + y + {c} = 0";
                            
            }

            return result;
            
        }
    }
}
