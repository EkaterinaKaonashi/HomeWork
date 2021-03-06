using System;
namespace HomeWork
{
    public class Lesson004
    {
        public Lesson004()
        {
        }

        public static void FirstTask()
        {
            //Найти минимальный элемент массива

            int[] array = new int[10];
            //{10,15,75,32,522,86,11,21,4,56};


            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine(min);


        }

        public static void SecondTask()
        {
            //Найти максимальный элемент массива
            int[] array = new int[18];


            Random random = new Random();

            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i]
            //}

            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.Write(array[i] + " ");

                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(max);

        }

        public static void ThirdTask()
        {
            //Найти индекс минимального элемента массива
            int[] array = new int[21];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

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

            Console.WriteLine(index);

        }

        public static void FourthTask()
        {
            //Найти индекс максимального элемента массива

            int[] array = new int[32];
            Random r = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-15, 26);
                Console.Write(array[i] + " ");
            }


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
            Console.WriteLine();
            Console.WriteLine(max);
        }

        public static void FifthTask()
        {
            //Посчитать сумму элементов массива с нечетными индексами

            int[] array = new int[7];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
                if (i % 2 != 0)
                {
                    sum += array[i];
                }

                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

        public static void SixthTask()
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5,6};

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array.Length   - i;
                array[array.Length  - 1 -i] = tmp;
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }

        public static void SeventhTask()
        {
            //Посчитать количество нечетных элементов массива

            int[] array = new int[9] { 3,7,3,2,6,5,8,7,4};

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int q = array[i];
                if(q %2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public static void EighthTask()
        {
            int[] array = new int[7] { 1, 2, 3, 4,5,6,7};
            
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
            
            

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }



        }

        public static void BubbleSort()
        {
            int[] array = new int[15];
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,26);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

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
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void InsertSort()
        {
        int[] array = new int[21];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
        array[i] = random.Next(0, 31);
        Console.Write(array[i] + " ");
        }
        Console.WriteLine();


            
            for(int i = 0; i < array.Length-1; i++)
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
           


        
        for (int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
        }
    }
}
    
