using System;
class Program 
{
    static void Main(String[] args)
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

        Console.WriteLine($"Sum of marks: {sum}");
        Console.ReadLine();
    }
}