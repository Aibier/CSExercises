using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your username:");
            string username = Console.ReadLine();
            Console.Write("Please enter your gender:");
            string usergender = Console.ReadLine();
            
            if (usergender == "M")
            {
                Console.WriteLine("Good Morning Mr." + username);

            }

            { if(usergender=="F")
                Console.WriteLine("Good Morning MS."+usergender);

            
             else 
            {
                Console.WriteLine("The name u entered cannot be identified");
            }
               
        }
            

            
        }
    }
}