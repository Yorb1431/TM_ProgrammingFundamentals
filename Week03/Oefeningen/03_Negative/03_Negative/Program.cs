namespace _03_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in a number and return the negative number when a number is already negative, nothing changes, when the number is 0, print 'error converting'.

 

                Input/Output
                        input:
                            183
                        output:
                            -183

                        input:
                            -26
                        output:
                             -26
             */

            int number = Convert.ToInt32(Console.ReadLine());

            if (0 < number)
            {
                int NegatiefNumber = -Math.Abs(number);

                Console.WriteLine(NegatiefNumber);
            }
            else if (0 > number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("error converting");
            }
        }
    }
}
