namespace c_sharp_delegate2
{//hw ex-5
    internal class Program
    {
        static void Main()
        {
            var random = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints[i] = random.Next(-10, 10);
            }
            Console.WriteLine("Array of random numbers: ");
            foreach (var i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Func<int[], int> UnicNegative = nums => {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < 0)
                    {
                        bool ToAddCount = true;
                        for (int j = 0; j < nums.Length; j++)
                        {
                            if (nums[i] == nums[j] && i != j)
                            {
                                ToAddCount = false;
                                break;
                            }
                        }

                        if (ToAddCount)
                        {
                            count++;
                        }
                    }
                }
                return count;
            };

            Console.WriteLine("Number of unique, negative numbers : " + UnicNegative(ints));
        }
    }
}

