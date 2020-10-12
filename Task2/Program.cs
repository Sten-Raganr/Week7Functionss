using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender:");
            Gender();
        }
        public static void Gender()
        {
            bool correctanswer = false;
            while (!correctanswer)
            {
                string gender = Console.ReadLine().ToLower();
                if (gender == "male")
                {
                    Console.WriteLine("Hello, Sir!");
                    correctanswer = true;
                }
                else if (gender == "female")
                {
                    Console.WriteLine("Hello, Madam!");
                    correctanswer = true;
                }
                else Console.WriteLine("enter male or female!!!!!!!!!!!!!");
            }
            
        }
    }
}
