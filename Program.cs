namespace c_sharp_delegate2
{//dev
    internal class Program
    {
        delegate void CalcNumber(ref double x);
        static void Mult2(ref double x)
        {
            x *= 2;
            Console.WriteLine($"x * 2");
        }
        static void Mult3(ref double x)
        {
            x *= 3;
            Console.WriteLine($"x * 3");
        }
        static void Sqrt(ref double x)
        {
            x *= x;
            Console.WriteLine($"x * x");
        }
        static void Add3(ref double x)
        {
            x += 3;
            Console.WriteLine($"x + 3");
        }
        static void Subst4(ref double x)
        {
            x -= 4;
            Console.WriteLine($"x - 4");
        }
        static void Main()
        {
            double x;
            //create a delegate
            CalcNumber? CN = null;
            //add methods to the delegate
            CN += Mult2;
            CN += Mult3;
            CN += Sqrt;
            x = 1;
            //invoke the delegate
            CN?.Invoke(ref x);
            Console.WriteLine($"Result: x (36) = {x}");
            Console.WriteLine();
            //remove methods from the delegate
            CN -= Sqrt;
            CN -= Mult3;
            CN -= Mult2;

            //add methods to the delegate
            CN += Add3;
            CN += Subst4;
            CN += Sqrt;
            CN += Add3;
            //invoke the delegate
            x = 2;
            CN?.Invoke(ref x);
            Console.WriteLine($"Result: x = {x}");
            //remove methods from the delegate
            CN -= Add3;
            CN -= Sqrt;
            CN -= Subst4;
            CN -= Add3;
        }
    }
}
