using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter amount in USD: ");
        double usd = double.Parse(Console.ReadLine());
       
        Console.Write ("Enter exchange rate from USD to EUR: ");
        double exchangeRate = double.Parse(Console.ReadLine());
       
        double result = usd * exchangeRate;
       
        Console.WriteLine ($"Amount from USD to EUR: {result:F2}");
    }
}