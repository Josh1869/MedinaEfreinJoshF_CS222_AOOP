using System;

class TheFinalTotal
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        
        if (n < 0)
        {
            Console.Write("Enter another integer: ");
            int m = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }

            Console.WriteLine(result);
        }
        
        else if (n == 0)
        {
            Console.WriteLine("Nothing Happened");
        }
        
        else if (n % 2 == 0)
        {
            Console.WriteLine("The number is even");
            int square = n * n;
            Console.WriteLine(square);
        }
        
        else if (n % 2 != 0)
        {
            Console.WriteLine("The number is odd");
            int cube = n * n * n;
            Console.WriteLine(cube);
        }
    }
}