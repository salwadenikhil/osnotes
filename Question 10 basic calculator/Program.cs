using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result;
        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Addition: {num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Subtraction: {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Multiplication: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Division: {num1} / {num2} = {result:F2}");
                }
                else
                    Console.WriteLine("Error: Division by zero!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        Console.ReadLine();
    }
}