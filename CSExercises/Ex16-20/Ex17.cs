using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name:");
            string username = Console.ReadLine();
            Console.Write("Please enter your gender:");
            string usergender=Console.ReadLine();
            Console.Write("Please enter your age :");
            int userage = Convert.ToInt32(Console.ReadLine());
            if (usergender == "M")
            {
                if (userage <= 40)
                    Console.WriteLine("Good Morning Mr." + username);
                else
                    Console.Write("Good Morning Uncle" + username);
            }
            if (usergender == "F")
            {if(userage<=40)
                Console.Write("Good Morning Ms." + usergender);
            else
            {
                Console.Write("Good Morning Aunty"+username );
            }
            }


            
        }
    }
}