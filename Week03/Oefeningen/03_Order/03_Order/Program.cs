namespace _03_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read three numbers
            double nummer01 = double.Parse(Console.ReadLine());
            double nummer02 = double.Parse(Console.ReadLine());
            double nummer03 = double.Parse(Console.ReadLine());

            // Determine the order and print in descending order
            if (nummer01 >= nummer02 && nummer01 >= nummer03)
            {
                if (nummer02 >= nummer03)
                {
                    Console.WriteLine(nummer01 + " " + nummer02 + " " + nummer03);
                }
                else
                {
                    Console.WriteLine(nummer01 + " " + nummer03 + " " + nummer02);
                }
            }
            else if (nummer02 >= nummer01 && nummer02 >= nummer03)
            {
                if (nummer01 >= nummer03)
                {
                    Console.WriteLine(nummer02 + " " + nummer01 + " " + nummer03);
                }
                else
                {
                    Console.WriteLine(nummer02 + " " + nummer03 + " " + nummer01);
                }
            }
            else // num3 is the largest
            {
                if (nummer01 >= nummer02)
                {
                    Console.WriteLine(nummer03 + " " + nummer01 + " " + nummer02);
                }
                else
                {
                    Console.WriteLine(nummer03 + " " + nummer02 + " " + nummer01);
                }
            }
        }
    }
}