namespace Hometask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = CreateRandArray(10);
            DisplayArray(array1);
            //Array.Sort(array1);
            //SelectionSort(array1);
            BubbleSort(array1);
            DisplayArray(array1);
            //int[,] array2 = new int[3,4];
            //int[,,] array3 = new int[2,3,4];
        }


        static void DisplayArray(int[] array)
        {
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }

        static int[] CreateRandArray(int size)
        {
            int[] ints = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                ints[i] = random.Next(100);
            }

            return ints;
        }

        static void SelectionSort(int[] array)
        {
            int size = array.Length;
            for(int i = 0; i < size - 1; i++ )
            {
                int min_index = i;
                for(int j = i + 1; j < size; j++ )
                {
                    if (array[j] < array[min_index] )
                        min_index = j;                    
                }
                int temp = array[min_index];
                array[min_index] = array[i];
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
    }
}