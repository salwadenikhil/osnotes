using System;

class program
{
    static void Main(string[] args)
    {

        Console.Write("Enter a char");
        char ch = Console.ReadKey().KeyChar;
        int asciiValue = (int)ch;
        Console.WriteLine($"\nASCII value of {ch} is: {asciiValue}");
        Console.ReadLine();
    }
}