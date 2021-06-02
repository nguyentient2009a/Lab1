using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------Teacher Management--------");
                Console.WriteLine("1. Create student.");
                Console.WriteLine("2. Show list student.");
                Console.WriteLine("3. Show detail information student.");
                Console.WriteLine("4. Update list student.");
                Console.WriteLine("5. Delete student.");
                Console.WriteLine("6. Exit program.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please enter your choice (1 to 6):");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;

                    case 4:
                        Console.WriteLine("4");

                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                }

                Console.ReadLine();
                if (choice == 6)
                {
                    break;
                }
            }
        }
    }
}