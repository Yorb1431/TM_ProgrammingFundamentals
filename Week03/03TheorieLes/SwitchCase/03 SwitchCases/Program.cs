using System;
namespace _03_SwitchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //info datums gecombineerd met SWITCH CASES
            int weekdag = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekdag);

            string dagInWoorden = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dagInWoorden);

            //Console.WriteLine(DateTime.Now); --> alle gegevens die we bijhouden

            DateTime yesterday = new DateTime(2024, 10, 02);
            string dag = yesterday.DayOfWeek.ToString();
            Console.WriteLine(yesterday); // 02/10/2024 00:00:00

            DateTime verjaardag = new DateTime(2005, 05, 11); //jjjj,mm,dd
            dag = verjaardag.DayOfWeek.ToString();
            Console.WriteLine(dag);


















        }
    }
}
