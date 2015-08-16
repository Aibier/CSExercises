using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("salary");
            double s = double.Parse(Console.ReadLine());
            double ha = (s * 10/100);
            double ta = (s * 3/100);
            double ts = s + ha + ta; 
            Console.WriteLine("TotalIncome :{0:c}",ts);
        }
    }
}
