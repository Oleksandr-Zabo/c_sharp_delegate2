namespace c_sharp_delegate2
{//hw ex-4
    internal class Program
    {
        static void Main()
        {
            var random = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Array of random numbers: ");
            foreach (var i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Func<int[], int> countPositive = nums => nums.Count(n => n > 0);

            Console.WriteLine("Number of multiples of 7: " + countPositive(ints));
        }
    }
}
