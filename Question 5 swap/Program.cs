using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
        Console.ReadLine();
    }
}