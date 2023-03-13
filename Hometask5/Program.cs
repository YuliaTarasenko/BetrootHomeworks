using System.Drawing;

namespace Hometask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = CreateRandArray(10);
            DisplayArray(array1);
            SelectionSort(array1);
            BubbleSort(array1);
            InsertionSort(array1);
            DisplayArray(array1);
            int[,] array2 = CreateRandArray(3, 4);
            DisplayArray(array2);
            int[,,] array3 = CreateRandArray(2, 3, 4);
            DisplayArray(array3);
        }


        static void DisplayArray(int[] array)
        {
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }

        static void DisplayArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void DisplayArray(int[,,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    for (var k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[] CreateRandArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100);
            }

            return array;
        }

        static int[,] CreateRandArray(int size1, int size2)
        {
            int[,] array = new int[size1,size2];
            Random random = new Random();
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    array[i,j] = random.Next(100);
                }
            }

            return array;
        }

        static int[,,] CreateRandArray(int size1, int size2, int size3)
        {
            int[,,] array = new int[size1, size2,size3];
            Random random = new Random();
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    for (int k = 0; k < size3; k++)
                    {
                        array[i, j, k] = random.Next(100); 
                    }
                }
            }

            return array;
        }

        static void SelectionSort(int[] array)
        {
            int size = array.Length;
            for(int i = 0; i < size - 1; i++ )
            {
                int minIndex = i;
                for(int j = i + 1; j < size; j++ )
                {
                    if (array[j] < array[minIndex] )
                        minIndex = j;                    
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        static void BubbleSort(int[]array)
        {
            int size = array.Length;
            for(int i = 0; i < size - 1 ; i++ )
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] array)
        {
            int size = array.Length;
            for (int i = 1; i < size; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}