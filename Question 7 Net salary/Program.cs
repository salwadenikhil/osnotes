using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter basic salary");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        double hra = basicSalary * 0.20;
        double da = basicSalary * 0.40;
        double grossSalary = basicSalary + hra + da;
        double pf = basicSalary * 0.10;
        double netSalary = grossSalary - pf;

        Console.WriteLine($"Basic salary:{basicSalary:F2}");
        Console.WriteLine($"HRA (20%): {hra:F2}");
        Console.WriteLine($"DA (40%): {da:F2}");
        Console.WriteLine($"Gross Salary: {grossSalary:F2}");
        Console.WriteLine($"PF (10%): {pf:F2}");
        Console.WriteLine($"Net Salary: {netSalary:F2}");
        Console.ReadLine();
    }
}