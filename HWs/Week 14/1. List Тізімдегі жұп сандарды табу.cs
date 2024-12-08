using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 12, 7, 9, 22, 18, 5, 6, 15, 4, 10 };

        Console.Write("Двоичные: ");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
    }
}