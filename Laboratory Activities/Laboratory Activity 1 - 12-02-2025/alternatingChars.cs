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

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write("-");
            }

            if (i % 2 != 0)  
            {
                Console.Write(firstChar);
            }
            else  
            {
                Console.Write(secondChar);
            }

            Console.WriteLine();
        }
    }
}

