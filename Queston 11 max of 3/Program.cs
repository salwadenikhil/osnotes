using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter first no");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second no");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third no");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max;
        if (num1 >= num2 && num1 >= num3)
            max = num1;
        else if (num2 >= num1 && num2 >= num3)
            max = num2;
        else max = num3;

        Console.WriteLine($"Maximum no is:{max}");
        Console.ReadLine();
    }
}