using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {


            
            Random r = new Random();

            int secretNumber = r.Next(0, 10);
            int guess = 0;
            int n = 0;
            while (guess  != secretNumber)
            {
                n = n + 1;
                Console.Write("Please enter an integer:");
                guess = Convert.ToInt32(Console.ReadLine());
            }
                {
                    if (n > 0 && n <= 2)
                    {
                        Console.WriteLine("You are a Wizard !{0}", n);
                    }
                    else if (n > 2 && n <= 5)
                    {
                        Console.WriteLine("You are a good guess !{0}", n);
                    }
                    else
                    {
                        Console.WriteLine("You are lousy !{0}",n);
                    }
                
            }  
        }
    }
}
