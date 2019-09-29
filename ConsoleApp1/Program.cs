using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please insert a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You wrote: "+ input);
        }
    }
}
