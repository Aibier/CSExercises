using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your marks(0-100):");
            int usermarks = Convert.ToInt32(Console.ReadLine());

            if (usermarks >=80 && usermarks <= 100)
            {
                Console.Write("Grade:A");
            }
             else if (usermarks >=60 && usermarks <80)
             {
                 Console.Write("Grade:B");
             }
             else if (usermarks >= 40 && usermarks < 60)
             {
                 Console.Write("Grade:C");
             }
             else if (usermarks >= 0 && usermarks < 40)
             {
                 Console.Write("Grade:F");
             }
            else
             {
                 Console.Write("Error");
             }

            
        }
    }
}