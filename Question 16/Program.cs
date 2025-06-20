using System;
using System.Data;
using System.Diagnostics;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int number  = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;
        if(number<=1)
            isPrime = false;
        else
        {
            for(int i = 2;i<=Math.sqrt(number);i++)
            {

            }
        }
    }
}