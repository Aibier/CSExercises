using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER A DOUBLE PRECISION NUMBER");
            double a = double.Parse(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("Square root:{0})",b);


        }
    }
}
