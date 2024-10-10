namespace _04Pyramides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *
            // * *
            // * * *
            // * * * *
            Console.WriteLine("\nPryramide 01");
            int x = 4;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }


            // * * * *
            // * * *
            // * *
            // *
            Console.WriteLine("\nPryramide 02");
            for (int i = 0; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nPryramide 03");
            // + + + *
            // + + * *
            // + * * *
            // * * * *
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("test");

            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPryramide 04");

            // * * * *
            // + * * *
            // + + * *
            // + + + *

            Console.WriteLine("Pyramid 4");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
