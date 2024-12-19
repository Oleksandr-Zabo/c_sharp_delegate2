namespace c_sharp_delegate2
{//hw ex-6
    internal class Program
    {
        static void Main()
        {
            string text = "The quick brown fox jumps over the lazy dog.";
            string wordToFind = "fox";

            Func<string, string, bool> containsWord = (txt, word) =>
            {
                txt = txt.ToLower();
                word = word.ToLower();

                string[] words = txt.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

               
                foreach (string w in words)
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
                return false;
            };

            
            bool result = containsWord(text, wordToFind);
            Console.WriteLine($"Does the text contain the word '{wordToFind}'? {result}");

           
            string anotherWordToFind = "cat";
            bool anotherResult = containsWord(text, anotherWordToFind);
            Console.WriteLine($"Does the text contain the word '{anotherWordToFind}'? {anotherResult}");
        }
    }
}


