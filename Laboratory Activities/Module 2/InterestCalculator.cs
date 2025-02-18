using System;

public class InterestCalculator
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());
       
        Console.Write ("Enter the rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
       
        Console.Write ("Enter time in years: ");
        int time = int.Parse(Console.ReadLine());
       
        double interest = (principal*rate*time)/100;
       
        Console.WriteLine ($"Simple interest: {interest:F2}");
    }
}