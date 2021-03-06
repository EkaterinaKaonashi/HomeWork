using System;
namespace HomeWork
{
    public class Lesson005
    {
        public Lesson005()
        {
        }
        public static void FirstTask()
        {
            //Найти минимальный элемент массива
            int[,] array = new int[3, 5]
            {
                { 12,14,15,16,61 },
                {41,9,8,9, 9} ,
                {31,54,73,21,7 }
            };

            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexI, indexJ] > array[i, j])
                    {
                        indexI = i;
                        indexJ = j;
                    }

                }

            }
            Console.WriteLine(array[indexI, indexJ]);
        }
        public static void SecondTask()
        {
            int[,] array = new int[3, 5]
            {
                {2,41,5,15,67 },
                {5,26,7,2,6 },
                {5,7,26,78,2 }
            };

            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[indexI, indexJ])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine(array[indexI, indexJ]);


        }

        public static void ThirdTask()
        {
            //Найти индекс минимального элемента массива

            int[,] array = new int[3, 5]
            {
                { 12,17,15,16,61 },
                {41,9,8,9, 9} ,
                {31,54,73,21,71 }
            };

            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[indexI, indexJ])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine($"Индекс минимального элемента: {indexI},{indexJ}");

        }
        public static void FouthTask()
        {
            //Найти индекс максимального элемента массива

            int[,] array = new int[3, 5]
            {
                { 12,14,15,16,61 },
                {41,9,8,9, 9} ,
                {31,54,73,21,71 }
            };
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[indexI, indexJ])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine($"Индекс максимального элемента: {indexI},{indexJ}");


        }
        public static void FivethTask()
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно.


            int[,] array = new int[4, 5]
            {
                {12,17,15,16,61 },
                {41,9,8,9, 7} ,
                {31,54,2,21,1 },
                {1,2,1,4,3 }
            };

            int n = array.GetLength(0);
            int k = array.GetLength(1);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    int curnt = array[i, j];
                    if (checkIndex(i - 1, n))
                    {
                        if (array[i - 1, j] >= curnt)
                        {
                            continue;
                        }
                    }
                    if (checkIndex(j + 1, k))
                    {
                        if (array[i, j + 1] >= curnt)
                        {
                            continue;
                        }
                    }
                    if (checkIndex(i + 1, n))
                    {
                        if (array[i + 1, j] >= curnt)
                        {
                            continue;
                        }
                    }
                    if (checkIndex(j - 1, k))
                    {
                        if (array[i, j - 1] >= curnt)
                        {
                            continue;
                        }
                    }

                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static bool checkIndex(int index, int length)
        {
            return index >= 0 && index < length;
        }

        public static void SixthTask()
        {
            //Отразите массив относительно его главной диагонали.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool cheacSize = a / b == 1 ? true : false;

            Random r = new Random();

            int[,] array = new int[a, b];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 15);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int l = array.GetLength(0);
            int n = array.GetLength(1);

            if (cheacSize == true)
            {

                for (int i = 0; i < l; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (i != j)
                        {
                            int tmp = array[i, j];
                            array[i, j] = array[j, i];
                            array[j, i] = tmp;
                        }
                    }
                }
                Console.WriteLine();
                PrintArray(array);

                Console.WriteLine();
            }
            else
            {
                int[,] newArray = new int[b, a];
                for (int i =0; i < newArray.GetLength(0); i++)
                {
                    for(int j = 0; j < newArray.GetLength(1); j ++)
                    {
                        newArray[i, j] = array[j, i];
                        Console.Write(newArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }



            }

        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SeventhTask()
        {
            int[] array = new int[15];

            Random r = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 15);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int l = array.Length;

            int count = 0;
            for (int i=0; i < l; i++)
            {
                int curent = array[i];
                if(check(i -1, l))
                {
                    if (array[i-1] > curent)
                    {
                        continue;
                    }
                    
                }
                if (check(i + 1, l))
                {
                    if(array[i+1] > curent)
                    {
                        continue;
                    }
                }
                count++;
            }
            Console.WriteLine(count);
        }
        public static bool check(int index, int length)


        {
            return index >= 0 && index < length;
        }

        public static void SixthTask1()
        {
            //Отразите массив относительно его главной диагонали

        }


    }
}
