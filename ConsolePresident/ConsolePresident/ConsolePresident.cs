// See https://aka.ms/new-console-template for more information
using System;
namespace PresidentConsole
{
    class ConsolePresident
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            int age = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter your years of residence in the United States.");
            int yearsOfResidence = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Are you a natural born citizen of the United States? (Answer True or False.)");
            bool citizen = (bool)Convert.ToBoolean(Console.ReadLine());
            if(citizen &&  age >= 35 && yearsOfResidence >= 14)
            {
                Console.WriteLine("You are qualified for president of the United States of America!");
            }
            else
            {
                Console.WriteLine("You are not qualified for President of the USA.... but you can still make a difference in life!");
            }




        }
    }
}
 