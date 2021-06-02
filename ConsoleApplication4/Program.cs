using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 9: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you entered is{a}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a * i}");
            }
        }
    }
}