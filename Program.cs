namespace c_sharp_delegate2
{//hw ex-3
    internal class Program
    {
        

        static void Main()
        {
            var random= new Random();
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints[i] = random.Next(1, 100);
            }
            Console.WriteLine("Array of random numbers: ");
            foreach (var i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Func<int[], int> countMultiplesOfSeven = nums => nums.Count(n => n % 7 == 0);

            Console.WriteLine("Number of multiples of 7: " + countMultiplesOfSeven(ints));
        }
    }
}
