namespace _04While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            Console.Write("START! press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("press y to continue again: ");
                answer = Console.ReadLine();
            }


        }
    }
}
