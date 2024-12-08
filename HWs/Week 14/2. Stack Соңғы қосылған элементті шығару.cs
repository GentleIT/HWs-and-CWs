using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        Console.WriteLine("Последний добавленный элемент: " + stack.Peek());
        stack.Pop();

        Console.Write("Оставшиеся элементы: ");
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
    }
}
