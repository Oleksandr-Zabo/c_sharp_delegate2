namespace c_sharp_delegate2
{//hw ex-1
    internal class Program
    {
        public delegate string GetRgbValue(string color);
        static void Main(string[] args)
        {
            GetRgbValue GetRgb;
            GetRgb = delegate (string color)
            {
                color = color.ToLower();
                switch (color)
                {
                    case "red":
                        return "(255, 0, 0)";
                    case "green":
                        return "(0, 255, 0)";
                    case "blue":
                        return "(0, 0, 255)";
                    case "yellow":
                        return "(255, 255, 0)";
                    case "violet":
                        return "(238, 130, 238)";
                    default:
                        throw new Exception("Unknown color");
                }
            };

            // Test the method with different rainbow colors
            try
            {
                Console.WriteLine("RGB for Red: " + GetRgb("Red"));
                Console.WriteLine("RGB for Green: " + GetRgb("Green"));
                Console.WriteLine("RGB for Yellow: " + GetRgb("yellow"));
                Console.WriteLine("RGB for Violet: " + GetRgb("VIOLET"));
                Console.WriteLine("RGB for Unknown: " + GetRgb("Unknown")); // This will throw an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}