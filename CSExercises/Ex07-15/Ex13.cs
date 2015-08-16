using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("distance");
            double d = double.Parse(Console.ReadLine());
            double f = (0.4 * d) + 2.4;
            Console.WriteLine("TotalFare:{0:#00.00}",Math.Ceiling(f));
            Console.ReadLine();
            
        }
    }
}
