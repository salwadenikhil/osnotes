using System;
class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.Write($" {i}: {(char)i} ");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }