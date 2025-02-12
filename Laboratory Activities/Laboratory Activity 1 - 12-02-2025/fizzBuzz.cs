using System;

class FizzBuzz
{
    static void Main()
    {
        int upperBound = 20;

        for (int i = 1; i <= upperBound; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine("Fizz");
                }
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
