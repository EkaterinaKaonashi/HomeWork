using System;
namespace HomeWork
{
    public class Lesson005
    {
        public Lesson005()
        {
        }
        public static int FirstTask(int[,] array)
        {
            //Найти минимальный элемент массива
            

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
            return (array[indexI, indexJ]);
        }
        public static int SecondTask(int[,] array)
        {
            

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
          return (array[indexI, indexJ]);


        }

        public static int[] ThirdTask(int[,] array)
        {
            //Найти индекс минимального элемента массива


            int[] arrayOfIndex = new int[2];
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
            arrayOfIndex[0] = indexI;
            arrayOfIndex[1] = indexJ;
            return arrayOfIndex; // как вернуть два числа без массива?

        }
        public static int[] FouthTask(int[,] array)
        {
            //Найти индекс максимального элемента массива

            
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
            int[] nw = new int[2];
            nw[0] = indexI;
            nw[1] = indexJ;
            return nw;


        }
        public static int FivethTask(int[,] array)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно.


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
            return count;
        }

        static bool checkIndex(int index, int length)
        {
            return index >= 0 && index < length;
        }

        public static int[,] SixthTask(int[,] array)
        {
            //Отразите массив относительно его главной диагонали.
            
            int a = array.GetLength(0);
            int b = array.GetLength(1);
            bool cheacSize = a / b == 1 ? true : false;

           

            //int[,] array = new int[a, b];


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
                return array;
            }
            else
            {
                int[,] newArray = new int[b, a];
                for (int i =0; i < newArray.GetLength(0); i++)
                {
                    for(int j = 0; j < newArray.GetLength(1); j ++)
                    {
                        newArray[i, j] = array[j, i];
                        
                    }
                    
                }

                return newArray;

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

      
    }
}
