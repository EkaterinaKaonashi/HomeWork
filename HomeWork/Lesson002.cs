using System;
namespace HomeWork
{
    public class Lesson002
    {
        public Lesson002()
        {


        }


        public static int FirstTask(int a,int b)
        {
            //Пользователь вводит 2 числа(A и B).Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B.

            

            int result = 0; ;

            if (a > b)
            {
                result = a + b;
                Console.WriteLine(result);
            }
            else if (a == b)
            {
                result = a * b;
                Console.WriteLine(result);
            }
            else if (a < b)
            {
                result = a - b;
                Console.WriteLine(result);
            }

            return result;

        }

        public static string SecondTask(int x, int y)
        {
            //Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y).
            string result = "";

            if (x > 0 && y > 0)
            {
                result = "Это первая четверть";
            }
            if (x < 0 && y > 0)
            {
                result = "Это вторая четверть";
            }
            if (x < 0 && y < 0)
            {
                result = "Это третья четверть";
            }
            if (x > 0 && y < 0)
            {
                result = "Это четвертая четверть";
            }
            if (x == 0 && y == 0 || x == 0 && y > 0 || y == 0 && x > 0)
            {
                result = "точка лежит на плоскости";
            }
            return result;

        }

        public static int[] ThirdTask(int a,int b,int c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

            int[] ar = new int[3];

            if (a < b && a < c)
            {
                ar[0] = a;

                if (b < c)
                {
                    ar[1] = b;
                    ar[2] = c;
                }
                else
                {
                    ar[1] = c;
                    ar[2] = b;
                }
            }
            else if (b < a && b < c)
            {
                ar[0] = b;

                if (a < c)
                {
                    ar[1] = a;
                    ar[2] = c;
                }
                else
                {
                    ar[1] = c;
                    ar[2] = a;


                }
            }

            else
            {
                ar[0] = c; 

                if (a < b)
                {
                    ar[1] = a;
                    ar[2] = b;
                }
                else
                {
                    ar[1] = b;
                    ar[2] = a;
                }
            }

            return ar;
        }

        public static double[] FourthTask(double a , double b, double c)
        {
            //Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0.

            

            double dis = (b * b) - 4 * a * c;
            double x1 = 0;
            double x2;
            double x;
            double[] ar = new double[2];

            if (dis < 0)

            {

                throw new Exception("Дискриминант меньше 0");

            }
            if (dis == 0)
            {
                x  = -(b / 2 * a);
                ar[0] = x;
               // Console.WriteLine("Есть один корень");
                //Console.WriteLine($" X = {x} ");
                //Console.WriteLine(a * (x*x) + b*x + c );
            }
            else if ( dis > 0)
            {

                x1 = (-b + Math.Sqrt(dis)) / (2*a);
                x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                ar[0] = x1;
                ar[1] = x2;

                //Console.WriteLine("Есть два кореня");
                //Console.WriteLine($" X1 = {x1} X2 = {x2} ");
                //Console.WriteLine(a * (x1 * x1) + b * x1 + c);
            }
            return ar;

        }

        public static string FifthTask(int number)

        {
            

            string n1 = "один";
            string n2 = "два";
            string n3 = "три";
            string n4 = "четыре";
            string n5 = "пять";
            string n6 = "шесть";
            string n7 = "семь";
            string n8 = "восемь";
            string n9 = "девять";
            


            string n20 = "двадцать";
            string n30 = "тридцать";
            string n40 = "сорок";
            string n50 = "пятьдесят";
            string n60 = "шестьдесят";
            string n70 = "семдесят";
            string n80 = "восемесят";
            string n90 = "девяносто";

            if (number > 0 && number <= 10)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine(n1);
                        break;
                    case 2:
                        Console.WriteLine(n2);
                        break;
                    case 3:
                        Console.WriteLine(n3);
                        break;
                    case 4:
                        Console.WriteLine(n4);
                        break;
                    case 5:
                        Console.WriteLine(n5);
                        break;
                    case 6:
                        Console.WriteLine(n6);
                        break;
                    case 7:
                        Console.WriteLine(n7);
                        break;
                    case 8:
                        Console.WriteLine(n8);
                        break;
                    case 9:
                        Console.WriteLine(n9);
                        break;



                }
            }

            string head = "";
            string tale = "";


            if (number >= 10 && number <20 )
            {
                switch (number)
                {

                    case 10:
                        head = "десять";
                        break;

                    case 11:
                        head = "одиннадцать";
                        break;
                    case 12:
                        head = "двенадцать";
                        break;
                    case 13:
                        head = "тринадцать";
                        break;
                    case 14:
                        head = "четырнадцать";
                        break;
                    case 15:
                        head = "пятнадцать";
                        break;
                    case 16:
                        head = "шестнадцать";
                        break;
                    case 17:
                        head = "семнадцать";
                        break;
                    case 18:
                        head = "восемнадцать";
                        break;
                    case 19:
                        head = "девятнадцать";
                        break;
                }
            }
            else if (number >= 20 && number <= 99)
            {
                int key1 = number / 10;
                int key2 = number % 10;

                switch (key1)
                {
                    case 2:
                        head = n20;
                        break;
                    case 3:
                        head = n30;
                        break;
                    case 4:
                        head = n40;
                        break;
                    case 5:
                        head = n50;
                        break;
                    case 6:
                        head = n60;
                        break;
                    case 7:
                        head = n70;
                        break;
                    case 8:
                        head = n80;
                        break;
                    case 9:
                        head = n90;
                        break;

                }

                switch (key2)
                {
                    case 1:
                        tale = n1;
                        break;
                    case 2:
                        tale = n2;
                        break;
                    case 3:
                        tale = n3;
                        break;
                    case 4:
                        tale = n4;
                        break;
                    case 5:
                        tale = n5;
                        break;
                    case 6:
                        tale = n6;
                        break;
                    case 7:
                        tale = n7;
                        break;
                    case 8:
                        tale = n8;
                        break;
                    case 9:
                        tale = n9;
                        break;
                }

                
            }
            string result = head + " " + tale;
            return result;
        }
    }
}
