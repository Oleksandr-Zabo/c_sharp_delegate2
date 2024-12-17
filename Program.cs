namespace c_sharp_delegate2
{//dev
    internal class Program
    {
        delegate int CubeDelegate(int x);

        static void Main()
        {
            //3
            var random = new Random();
            int x = random.Next(2, 10);
            CubeDelegate cube = x => x * x * x;
            Console.WriteLine($"Cube of {x} = {cube(x)}");

            //4
            Console.WriteLine($"Write date: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"Date: {date}");

            // Check if the day is a programmer's day == 13.09.2023 or 12.09.2024
            Func<DateTime, bool> isDayOfYear256 = date => date.DayOfYear == 256;
            
            Console.WriteLine($"Is the day a programmer's day? {isDayOfYear256(date)}");
        }
    }
}
