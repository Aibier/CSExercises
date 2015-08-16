using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a decimal precision number:");
            double a = double.Parse(Console.ReadLine());
            double b = Math.Sqrt(a);
           
            Console.WriteLine("square root:{0:###.###}",b);
        } 
    }
}
