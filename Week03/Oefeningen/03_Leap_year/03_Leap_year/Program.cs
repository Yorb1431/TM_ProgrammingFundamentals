namespace _03_Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in a year (integer) and print whether or not this year is/was a leap year.

                How to calculate a leap year:

                Has to be divisible by 4 but not 100

                Or

                Has to be divisible by 400

 

                Input/Output
                    input:
                        1700
                    output:
                        1700 is not a leap year
                
                    input:
                        2024
                    output:
                        2024 is a leap year
             */

            int leapyear = Convert.ToInt32(Console.ReadLine());
            int deling01 = (leapyear % 400);
            int deling02 = (leapyear % 4);
            int deling03 = (leapyear % 100);

            if (deling02 == 0 && deling03 != 0)
            {
                Console.WriteLine($"{leapyear} is a leap year");
            }
            else if (deling01 == 0)
            {
                Console.WriteLine($"{leapyear} is a leap year");
            }
            else
            {
                Console.WriteLine($"{leapyear} is not a leap year");
            }
        }
    }
}