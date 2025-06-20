using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = false;
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            isLeapYear = true;
        }

        if (isLeapYear)
            Console.WriteLine($"{year} is a Leap Year");
        else
            Console.WriteLine($"{year} is not a Leap Year");

        Console.ReadLine();
    }
}
