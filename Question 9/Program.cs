using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Basic Salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Total Sales Amount: ");
        double salesAmount = Convert.ToDouble(Console.ReadLine());

        double commissionRate;
        if (salesAmount >= 5000 && salesAmount <= 7500)
            commissionRate = 0.03;
        else if (salesAmount >= 7501 && salesAmount <= 10500)
            commissionRate = 0.08;
        else if (salesAmount >= 10501 && salesAmount <= 15000)
            commissionRate = 0.11;
        else if (salesAmount > 15000)
            commissionRate = 0.15;
        else
            commissionRate = 0;

        double commission = salesAmount * commissionRate;
        double netSalary = basicSalary + commission;

        Console.WriteLine($"Commission Earned: {commission:F2}");
        Console.WriteLine($"Net Salary: {netSalary:F2}");
        Console.ReadLine();
    }
}