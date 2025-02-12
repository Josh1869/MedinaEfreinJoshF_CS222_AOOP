using System;

class AlternatingChars
{
    static void Main()
    {
        Console.Write("First character: ");
        char firstChar = Console.ReadLine()[0]; 

        Console.Write("Second character: ");
        char secondChar = Console.ReadLine()[0]; 

        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Console.Write(new string('-', i));

            char toPrint = (i % 2 == 0) ? firstChar : secondChar;
            Console.WriteLine(toPrint);
        }
    }
}