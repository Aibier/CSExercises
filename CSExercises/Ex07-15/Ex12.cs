using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("distance");
            double d = double.Parse(Console.ReadLine());
            double f = (0.4 * d) + 2.4;
            Console.WriteLine("TotalFare:{0:000.00}", f);
            Console.ReadLine();
            
        }
    }
}
