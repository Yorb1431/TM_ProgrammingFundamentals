namespace _03_Special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char che = char.Parse(Console.ReadLine());
            string consonants = "ZRTYPMLKJHGFDSQWXCVBNzrtypmlkjhgfdsqwxcvbn";
            string vowels = "aeiouAEIOU";

            if (consonants.Contains(che))
            {
                Console.WriteLine("consonant");
            }
            else if (vowels.Contains(che))
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(che))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special character");
            }
        }
    }
}
