using ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        Student student = new();
        student.OnSelection += OracleDb;
        student.OnRejection += ExcelDb;
        student.Id = 1;
        student.Name = "Omkar Kancharlawar";
        student.Email = "omakr@gmail.com";
        student.Marks = 95;

       
        string result = student.CalculateResult();
        Console.WriteLine(result);
    }

    private static void OracleDb(string value)
    {
        Console.WriteLine($"Marks {value} stored in Oracle database");
    }

    private static void ExcelDb(string value)
    {
        Console.WriteLine($"Marks {value} stored in Excel database");
    }
}