using System;
namespace _03_Roots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Find all roots of a quadratic equation. The standard form of a quadratic equation is: ax² + bx + c = 0

                We calculate the roots by the formula x = (-b ± √D) / (2a) where the ± sign indicates that there will be two roots:
                - root1 = (-b + √(D)) / (2a)
                - root2 = (-b - √(D)) / (2a)

                The term D with the formula b^2-4ac is known as the discriminant of a quadratic equation. It specifies the nature of roots:
                - if D > 0, roots are real and different (print root1 and root2, round to 2 digits)
                - if D == 0, roots are real and equal (print one root, round to 2 digits)
                - if D < 0, roots are complex complex and different (print 'no real solution')
             
             
             Input/Output
                    Input:
                        1
                        -4
                        4
                    Output:
                        2

                          
             Input/Output
                    Input:
                        1
                        3
                        2
                    Output:
                        -1 v 2
             */
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Math.Pow(b, 2) - 4 * a * c);



        }
    }
}
