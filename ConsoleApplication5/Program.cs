using System;
using System.Text;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, fact = 1, i=1;
            Console.Write("Enter the factorial number 1 -20:");
            n = Int32.Parse(Console.ReadLine());
            for(i=1; i<=n;i++)
                fact = fact *i;
            Console.WriteLine("The result of factorial calculation is: " + fact);
        }
    }
}