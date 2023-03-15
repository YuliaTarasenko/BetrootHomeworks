using System.Drawing;

namespace Hometask5
{
    internal class Program
    {
        enum SortAlgorithmType
        {
            SelectionSort,
            BubbleSort,
            InsertionSort
        }

        enum OrderBy
        {
            Asc,
            Desc
        }        

        static void Main(string[] args)
        {
            int[] array1 = CreateRandArray(10);
            DisplayArray(array1);
            int[] sortedArray1 = Sort(array1, SortAlgorithmType.SelectionSort, OrderBy.Asc);
            DisplayArray(array1);
            int[] sortedArray2 = Sort(array1, SortAlgorithmType.BubbleSort, OrderBy.Desc);
            DisplayArray(array1);
            int[] sortedArray3 = Sort(array1, SortAlgorithmType.InsertionSort, OrderBy.Desc);
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

        static int[] Sort(int[] array, SortAlgorithmType type, OrderBy order, params int[] numbers)
        {
            switch (type)
            {
                case SortAlgorithmType.SelectionSort: return SelectionSort(array, order);
                case SortAlgorithmType.BubbleSort: return BubbleSort(array, order);
                case SortAlgorithmType.InsertionSort: return InsertionSort(array, order);
                default: return array;
            }
        }

        static int[] SelectionSort(int[] array, OrderBy order)
        {
            int size = array.Length;
            for(int i = 0; i < size - 1; i++ )
            {
                int minIndex = i;
                for(int j = i + 1; j < size; j++ )
                {
                    if(order == OrderBy.Asc && array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    else if (order == OrderBy.Desc && array[j] > array[minIndex])
                    { 
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }

        static int[] BubbleSort(int[] array, OrderBy order)
        {
            int size = array.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if(order == OrderBy.Asc && array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                    else if (order == OrderBy.Desc && array[j] < array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            return array;
        }

        static int[] InsertionSort(int[] array, OrderBy order)
        {
            int size = array.Length;
            for (int i = 1; i < size; i++)
            {
                int key = array[i];
                int j = i - 1;
                if(order == OrderBy.Asc)
                {
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }
                else if ( order == OrderBy.Desc)
                {
                    while (j >= 0 && array[j] < key)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }

                array[j + 1] = key;
            }
            return array;
        }

        //static int[,,] Sort3d()
        //{
        //    // sample 3x4x5 array
        //    int[,,] myArray = new int[3, 4, 5]
        //    {
        //    { { 6, 5, 4, 3, 2 }, { 1, 2, 3, 4, 5 }, { 6, 5, 4, 3, 2 }, { 1, 2, 3, 4, 5 } },
        //    { { 9, 8, 7, 6, 5 }, { 4, 5, 6, 7, 8 }, { 9, 8, 7, 6, 5 }, { 4, 5, 6, 7, 8 } },
        //    { { 3, 2, 1, 0, 9 }, { 8, 7, 6, 5, 4 }, { 3, 2, 1, 0, 9 }, { 8, 7, 6, 5, 4 } }
        //    };
        //    // create an one-dimensional temp array
        //    int[] flatArray = new int[myArray.Length];
        //    // transfer the 3d array to 1d
        //    Buffer.BlockCopy(myArray, 0, flatArray,
        //        0, sizeof(int) * myArray.Length);
        //    // sort 1d array
        //    Array.Sort(flatArray);
        //    // transfer the sorted 1d array back to the 3d one
        //    Buffer.BlockCopy(flatArray, 0, myArray,
        //        0, sizeof(int) * myArray.Length);
        //    return myArray;
        //}
    }
}