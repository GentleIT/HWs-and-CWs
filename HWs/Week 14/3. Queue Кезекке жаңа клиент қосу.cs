using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Клиент 1");
        queue.Enqueue("Клиент 2");
        queue.Enqueue("Клиент 3");

        queue.Enqueue("Новый Клиент 1");
        queue.Enqueue("Новый Клиент 2");

        Console.Write("Список Клиентов: ");
        foreach (string client in queue)
        {
            Console.Write(client + ", ");
        }
    }
}