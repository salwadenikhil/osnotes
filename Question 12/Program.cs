using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee Number: ");
        int empNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Department Number (10,20,30,40,50): ");
        int deptNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Designation Code (M,S,A,s,a): ");
        char desigCode = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string deptName = deptNo switch
        {
            10 => "Purchase",
            20 => "Sales",
            30 => "Production",
            40 => "Marketing",
            50 => "Accounts",
            _ => "Invalid Department"
        };

        string designation = desigCode switch
        {
            'M' => "Manager",
            'S' => "Supervisor",
            'A' => "Analyst",
            's' => "Sales Person",
            'a' => "Accountant",
            _ => "Invalid Designation"
        };

        Console.WriteLine($"\nEmployee Number: {empNo}");
        Console.WriteLine($"Department: {deptName}");
        Console.WriteLine($"Designation: {designation}");
        Console.ReadLine();
    }
}