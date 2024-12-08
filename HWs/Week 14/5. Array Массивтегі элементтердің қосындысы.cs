using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 7, 9, 10, 4, 6 };
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Сумма элементов массиыва: " + sum);
    }
}
