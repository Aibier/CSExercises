using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int secretNumber = 88;
            bool shouldStop = false;
            int guess ;
            
            while (!shouldStop)
            {
                Console.Write("Please enter your guess:");
               guess=Convert.ToInt32(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("Lucky You ");
                    shouldStop = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
