using System;

namespace Week7Functionss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year of birth:");
            Agecalculator();
        }
        public static void Agecalculator()        
        {             
            int Userinput = Int32.Parse(Console.ReadLine());                                      
            Console.WriteLine($"Your age is :{2020 - Userinput}");           
        }

    }
}
