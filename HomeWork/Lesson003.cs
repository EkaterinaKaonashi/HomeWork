using System;
namespace HomeWork
{
    public class Lesson003
    {
        public Lesson003()
        {
        }

        public static int FirstTask(int a,int b)
        {
            // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            
            int result = 1;
                
            while (b > 0)
            {
                result = result * a;
                b--;
            }
            return result;

        }

        public static int[] SecondTask(int a)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A
            if(a == 0)
            {
                throw new ArgumentException();
            }
            int j = 0;
            int[] ar = new int[1000 / a];
            for (int i = 1; i <= 1000; i++)
            {
                
                
                if ( i % a == 0)
                {
                    ar[j] = i;
                    j++;
                 
                }

            
            }
            return ar;

            
        }

        public static int ThirdTask(int a)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
           

            int x = 1;
            int count = 0;
            while ( x * x < a)
            {
                x++;
                count++;

                

            }
            Console.WriteLine(x);
            return count;
        }


        public static int FourthTask(int a )
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

            

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

            return del;
        }

        public static int FifthTask(int a,int b)
        {
            //Пользователь вводит 2 числа(A и B).Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            

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

            return sum;
        }

        public static int[] SixthTask(int n )
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

            if (n == 0)
            {
                throw new Exception("Значение должно быть больше 0");
            }


            int Fn = 1;
            int Fn2 = 1;
            int sum;
            int[] ar = new int[n];
            ar[0] = Fn;
            ar[1] = Fn2;

            int count = 2;

            int i = 0; 
            while (i < n-2)
            {
                sum = Fn + Fn2;
                Fn = Fn2;
                Fn2 = sum;
                i = i + 1;

                //Fn = (Fn - 1) + (Fn- 2);
               
                
                ar[count] = sum;
                count++;

            }
            return ar;
            
        }

        public static int SeventhTask(int a,int b)
        {
            //Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.

            int res;
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
                res = a;
            }
            else
            {
                res = b;
            }

            return res;

        }

        public static int EighthTask(int number)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.

            //double number = Convert.ToDouble(Console.ReadLine());

            //double n = Math.Pow(number, 1.0 / 3.0);

            //Console.WriteLine(n);

            Console.WriteLine("Введите число больше 0:");
                

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

            return midle; 


            




        }

        public static int NinthTask(int a)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            
            int oddNumber = 0;

           for (int i=0; i <= a; i++)
            {
                if(i % 2 != 0)
                {
                    oddNumber++;
                }
            }


            return oddNumber;

        }

        public static int TenthTask(int num)
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

           string a = Convert.ToString(num);
            

            //int reverse = a % 10; // почему без этого действия выводит только 2 цифры?
            //Console.Write(reverse);


            //while ((a = a / 10) != 0)
            //{
            //    Console.Write(a % 10);
            //}
            string rev = "";
            for(int i = a.Length -1; i>=0; i--)
            {
                rev += a[i];
            }
            int newrev = Convert.ToInt32(rev);
            return newrev;

        }

        public static int[] EleventhTask(string n)
        {
            // Пользователь вводит целое положительное  число(N).Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных

            

            int evenNumberSum = 0;
            int oddNumberSum= 0;
            int even = 0;
            int odd = 0;

            int count = 0;
            for (int i = 0; i < n.Length; i++ )
            {
                int rev = int.Parse(n[i].ToString());

                if (rev % 2 == 0)

                {
                    evenNumberSum = evenNumberSum + rev;
                    count++;
                }

                else
                {
                    oddNumberSum += rev;
                }
            }

            int[] ar = new int[count];
            int j = 0;
            if (evenNumberSum > oddNumberSum)
            {

                for (int i = 0; i < n.Length; i++)
                {
                int rev = int.Parse(n[i].ToString());

                    if (rev % 2 == 0)

                    {
                        ar[j] = rev;
                        j++;

                    }
                }
            }
            else
            {
               throw new Exception ("Сумма нечетных чисел больше");
            }

            return ar;
              
        }

        public static string Twelfth(string n1,string n2)
        {
            // Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            
            char result = ' ';
            bool bo = false;

            for(int i = 0; i < n1.Length;i++)
            {
                result = n1[i];
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
            string ans;
            if (bo)
            {
                ans = "ДА";
            }
            else
            {
               ans =  "Нет";
            }

            return ans;
        }
    }
}
