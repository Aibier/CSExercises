using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Length a,b,c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double s = (a+b+c)/2;
            double S = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area:{0}", S);
            Console.ReadLine();   
        }
    }
}