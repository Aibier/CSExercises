using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distande:(km)");
            double d;
            d = Convert.ToDouble(Console.ReadLine());
            double d1=Math.Ceiling(d * 10) / 10;
            double f = 2.4 + 0.4 * (d1 - 0.5);
            double F = 5.8 + 0.5*(d1 - 9);
            if (d <= 0.5)
            {
                Console.Write("Total Fare $2.4");
            }
            else if (d > 0.5 && d <= 9)
            {
                Console.Write("Total Fare ${0}", f);
            }
            else if (d > 9)
            {
                Console.Write("Total Fare ${0}", F);
            }
            else
            {
                Console.Write("ERROR ,TYR AGAIN");
            }
            
        }
    }
}