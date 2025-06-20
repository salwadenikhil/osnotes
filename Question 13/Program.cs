using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter date (dd/mm/yy): ");
        string[] dateParts = Console.ReadLine().Split('/');
        int day = int.Parse(dateParts[0]);
        int month = int.Parse(dateParts[1]);
        int year = int.Parse(dateParts[2]) + (dateParts[2].Length == 2 ? 2000 : 0);

        string monthName = month switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "Invalid Month"
        };

        int daysInMonth = month switch
        {
            2 => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? 29 : 28,
            4 or 6 or 9 or 11 => 30,
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            _ => 0
        };

        if (daysInMonth == 0)
            Console.WriteLine("Invalid month entered!");
        else
            Console.WriteLine($"Month: {monthName}, Total Days: {daysInMonth}");
        Console.ReadLine();
    }
}