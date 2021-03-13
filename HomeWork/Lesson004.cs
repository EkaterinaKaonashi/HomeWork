using System;
namespace HomeWork
{
    public class Lesson004
    {
        public Lesson004()
        {
        }

        public static int FirstTask(int[] array)
        {
            //Найти минимальный элемент массива

            
            //{10,15,75,32,522,86,11,21,4,56};


            //Random random = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next();
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine();

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;


        }

        public static int SecondTask(int[] array)
        {
            //Найти максимальный элемент массива
            

            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
               

                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;

        }

        public static int ThirdTask(int[] array)
        {
            //Найти индекс минимального элемента массива
            

           

            int minValue = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    index = i;
                }
            }

            return index;

        }

        public static int FourthTask(int[] array)
        {
            //Найти индекс максимального элемента массива

         
            int maxValue = array[0];
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    max = i;

                }
            }
            return max;
        }

        public static int FifthTask(int[]array)
        {
            //Посчитать сумму элементов массива с нечетными индексами

           
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static int[] SixthTask(int[] array)
        {
            //Сделать реверс массива (массив в обратном направлении)

            

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length   - i -1];
                array[array.Length  - 1 -i] = tmp;
            }
            return array;

        }

        public static int SeventhTask(int[] array)
        {
            //Посчитать количество нечетных элементов массива

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int q = array[i];
                if(q %2 != 0)
                {
                    count++;
                }
            }
            return count;

        }

        public static int[] EighthTask(int[] array)
            
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312.

            for ( int i = 0; i < array.Length / 2; i++)
            {
                if (array.Length %2 != 0)
                {
                    int tmp = array[i];
                    array[i] = array[array.Length / 2 + i + 1];
                    array[array.Length / 2 + i + 1] = tmp;
                    
                }
                else
                {
                    int tmp = array[i];
                    array[i] = array[i + array.Length / 2];
                    array[array.Length / 2 + i] = tmp;
                }
            }

            return array;

        }

        public static int[] BubbleSort(int[]array)
        {
            //Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble
            int tmp;

            for(int i = 0; i<array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;

                    }
                }
            }
            return array;
        }

        public static int[] InsertSort(int[] array)
        {

            //Отсортировать массив по убыванию одним из способов

            for (int i = 0; i < array.Length-1; i++)
            {
                int indexOfMax = i;
                for (int j = i; j<array.Length; j++)
                {
                    
                    if (array[indexOfMax] < array[j])
                    {
                        indexOfMax = j;
                        //tmp = array[i];
                        //array[i] = array[j];
                        //
                        //array[j] = array[i];

                    }
                }
                int tmp = array[i];
                array[i] = array[indexOfMax];
                array[indexOfMax] = tmp; 

            }
            return array;

        }
    }
}
    
