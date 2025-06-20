using System;
class Program
{
    static void Main(string[] args)
    {
        double[] marks = new double[5];
        double sum = 0;

        Console.WriteLine("Enter 5 marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Mark {i + 1}: ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
            sum += marks[i];
        }

        double average = sum / 5;
        Console.WriteLine($"Average of marks: {average:F2}");
        Console.ReadLine();
    }
}