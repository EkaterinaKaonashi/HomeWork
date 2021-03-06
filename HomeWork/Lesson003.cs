using System;
namespace HomeWork
{
    public class Lesson003
    {
        public Lesson003()
        {
        }

        public static void FirstTask()
        {
            // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;
                
            while (b > 0)
            {
                result = result * a;
                b--;
            }
            Console.WriteLine(result);

        }

        public static void SecondTask()
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A

            int a = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < 1000; i++)
            {
                
                if ( i % a == 0)
                {
                    Console.WriteLine(i);
                 
                }
            
            }
            
        }

        public static void ThirdTask()
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            int a = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            int count = 0;
            while ( x * x < a)
            {
                x++;
                count++;

                

            }
            Console.WriteLine(x);
            Console.WriteLine(count);
        }


        public static void FourthTask()
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

            int a = Convert.ToInt32(Console.ReadLine());

            int del=1;

            for (int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    int resl = a / i;
                    if (i > del)
                    {
                        del = i;
                    }
                }
            }

            Console.WriteLine(del);
        }

        public static void FifthTask()
        {
            //Пользователь вводит 2 числа(A и B).Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum=0;
            int min = (a < b) ? a : b;
            int max = (a > b) ? a : b;


            for( min = min; min <= max; min++)
            {
                if (min % 7 == 0)
                {
                    sum += min;
                }
            }

            Console.WriteLine(sum);
        }

        public static void SixthTask()
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

            int n = Convert.ToInt32(Console.ReadLine());
            int Fn = 1;
            int Fn2 = 1;
            int sum;

            int i = 0; 
            while (i < n-2)
            {
                sum = Fn + Fn2;
                Fn = Fn2;
                Fn2 = sum;
                i = i + 1;

                //Fn = (Fn - 1) + (Fn- 2);
               
                Console.WriteLine(sum);

            }
            
        }

        public static void SeventhTask()
        {
            //Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && b != 0)
            { 
                    if(a > b)
                    {
                        a = a % b;
                    }
                    else  
                    {
                        b = b % a;
                       
                    }
           }

            if(a > b)
            {
                Console.WriteLine("Наибольший общий делитель " + a);
            }
            else
            {
                Console.WriteLine("Наибольший общий делитель " + b);
            }

        }

        public static void EighthTask()
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.

            //double number = Convert.ToDouble(Console.ReadLine());

            //double n = Math.Pow(number, 1.0 / 3.0);

            //Console.WriteLine(n);

            Console.WriteLine("Введите число больше 0:");
                int number = Convert.ToInt32(Console.ReadLine());

            int left = 0;
             int midle = 0;
            int right = number;

            while (midle * midle * midle != number)
            {
                midle = left + right / 2;
                if(midle *midle *midle >= number)
                {
                    right = midle;
                }
                else
                {
                    left = midle;
                }
            }

            Console.WriteLine($"{midle} в 3 степени = {number}");


            




        }

        public static void NinthTask()
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int a = Convert.ToInt32(Console.ReadLine());

            int oddNumber = 0;

           for (int i=0; i <= a; i++)
            {
                if(i % 2 != 0)
                {
                    oddNumber++;
                }
            }

            
            Console.WriteLine(oddNumber);

        }

        public static void TenthTask()
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

            int a = Convert.ToInt32(Console.ReadLine());

            int reverse = a % 10; // почему без этого действия выводит только 2 цифры?
            Console.Write(reverse);

            while ((a = a/10) != 0)
            {
                Console.Write(a % 10);
            }



           
        }

        public static void EleventhTask()
        {
            // Пользователь вводит целое положительное  число(N).Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных

            string n = Console.ReadLine();

            int evenNumberSum = 0;
            int oddNumberSum= 0;
            int even = 0;
            int odd = 0;

            for (int i = 0; i < n.Length; i++ )
            {
                int rev = int.Parse(n[i].ToString());

                if (rev % 2 == 0)

                {
                    evenNumberSum = evenNumberSum + rev;
                }

                else
                {
                    oddNumberSum += rev;
                }
            }

            if (evenNumberSum > oddNumberSum)
            {

                for (int i = 0; i < n.Length; i++)
                {
                int rev = int.Parse(n[i].ToString());

                    if (rev % 2 == 0)

                    {
                        Console.Write(rev);

                    }
                }
            }
            else
            {
                Console.WriteLine("Сумма нечетных чисел больше");
            }
              
        }

        public static void Twelfth()
        {
            // Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            char result = ' ';
            bool bo = false;

            for(int i = 0; i < n1.Length;i++)
            {
                result = n2[i];
                    //Convert.ToString(n1[i]);
                for(int j = 0; j< n1.Length; j++)
                {
                    if (n2[j].Equals(result))
                    {
                        bo = true;
                        break;
                    }
                   

                }

            }
            if (bo)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
