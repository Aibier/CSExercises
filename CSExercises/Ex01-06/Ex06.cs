using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an integer:");
            int  a = int.Parse(Console.ReadLine());
            double b = Math.Sqrt((double)a);

            Console.WriteLine("square root:{0}", b);
            
        }
    }
}
