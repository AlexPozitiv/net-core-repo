//Create an array of 10 random numbers
    public enum SortAlgorithmType
    {
        Selection_Sort,
        Bubble_Sort,
        Insertions_Sort
    }
class MyProgram
{
    public class Selection_Sort
    {
        private int[] data;
        private static Random generator = new Random();
        public int sizeOfArray;

        public Selection_Sort(int size)
        {
            sizeOfArray = size;
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 90);
            }
        }
        public void Sort()
        {
            //printArray();
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;
                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                Swap(i, smallest);
                printArray();
            }
        }
        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }
        private void printArray()
        {
            foreach (var element in data)
            {
                Console.Write(element + "  ");
            }
            Console.Write("\n\n");
        }
    }
    public class Bubble_Sort
    {
        private int[] data;
        private static Random generator = new Random();

        public Bubble_Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 90);
            }
        }
        public void Sort()
        {
            printArray();
            int temp;

            for (int j = 0; j <= data.Length - 2; j++)
            {
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
                printArray();
            }
            printArray();
        }
        private void printArray()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
    public class Insertions_Sort
    {
        private int[] data;
        private static Random generator = new Random();

        public Insertions_Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 90);
            }
        }
        public void Sort()
        {
            int n = data.Length;

            for (int i = 0; i < n; i++)
            {
                int curr = data[i];
                int j = i - 1;
                while (j >= 0 && curr < data[j])
                    {
                        data[j + 1] = data[j];
                    data[j] = curr;
                    j = j - 1;
                }
                printArray();
            }
            void printArray()
            {
                foreach (var element in data)
                {
                    Console.Write(element + " ");
                }
                Console.Write("\n\n");
            }
        }
    }
    public class Quick_Sort
    {
        private int[] data;
        private static Random generator = new Random();
        public Quick_Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(20, 90);
            }
        } // add random nmbr

        public void Sort()
        {
            printArray();
            QuickSort(data);
            printArray();
        }
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;

            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        public void printArray()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }

    }
    public class Multi_Sort
    {
        private int[] data;
        int dataLength;

        public Multi_Sort(int[] _data, SortAlgorithmType _type)
        {
            dataLength = _data.Length;

            data = new int[dataLength];
            data = _data;
        } 
    }
    static void Main(string[] args)
    {
        int sizeOfArray = 10;

        Console.WriteLine("-------------------------------Selection_Sort------------------------------------------");
        Selection_Sort selection_ = new Selection_Sort(sizeOfArray);
        selection_.Sort();

        Console.WriteLine("---------------------------------Bubble_Sort----------------------------------------");
        Bubble_Sort bubbleSort_ = new Bubble_Sort(sizeOfArray);
        bubbleSort_.Sort();

        Console.WriteLine("-------------------------------Insertions_Sort------------------------------------------");
        Insertions_Sort intertSort_ = new Insertions_Sort(sizeOfArray);
        intertSort_.Sort();

        Console.WriteLine("---------------------------------Quick_Sort----------------------------------------");
        Quick_Sort quickSort = new Quick_Sort(sizeOfArray);
        quickSort.Sort();
    }
}