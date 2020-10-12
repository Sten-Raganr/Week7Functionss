using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year of birth:");
            string userinput = Console.ReadLine();
            int userage = Agecalculator(userinput);
            Console.WriteLine($"You are {userage} year old");
            Validateage(userage);
            
        }
        public static int Agecalculator(string userinput)
        {
            int userage = 2020 - Int32.Parse(userinput);
            return userage;
        }
        public static void Validateage(int age)
        {

            bool correctans = false;
            while (!correctans)
            {
                if (age < 18)
                {
                    Console.WriteLine("U are too young.");
                    correctans = true;                    
                }
                else if (age >= 18)
                {
                    Console.WriteLine("U are enough old.");
                    correctans = true;                   
                }
                else Console.WriteLine("wrong input, try again.");
            }
            
        }
    }
}
