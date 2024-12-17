namespace c_sharp_delegate2
{//dev
    internal class Program
    {
        delegate int[] ArrWork(int[] arr);
        static void Main()
        {
            var random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }

            Console.WriteLine("Standart arr:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            ArrWork dell_even = delegate (int[] arr)
            {
                int[] arr_odd = new int[arr.Length];
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr_odd[j] = arr[i];
                        j++;
                    }
                }
                int[] res_arr = new int[j];
                for (int i = 0; i < j; i++)
                {
                    res_arr[i] = arr_odd[i];
                }
                return res_arr;
            };

            ArrWork sort_arr = delegate (int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                return arr;
            };

            ArrWork arr_to_2 = delegate (int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= arr[i];
                }
                return arr;
            };

            int[] arr_1 = dell_even(arr);
            Console.WriteLine("Dell even in arr:");
            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.Write($"{arr_1[i]} ");
            }
            Console.WriteLine();


            arr_1 = sort_arr(arr_1);
            Console.WriteLine("Sort arr:");
            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.Write($"{arr_1[i]} ");
            }
            Console.WriteLine();

            arr_1 = arr_to_2(arr_1);
            Console.WriteLine("Sort arr:");
            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.Write($"{arr_1[i]} ");
            }
            Console.WriteLine();

        }
    }
}
