using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double absoluteValue = Math.Abs(number);
        Console.WriteLine($"Absolute value of {number} is: {absoluteValue}");
        Console.ReadLine();
    }
}