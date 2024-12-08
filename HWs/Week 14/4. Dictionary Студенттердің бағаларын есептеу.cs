using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> studentGrades = new Dictionary<string, int>();
        studentGrades.Add("Eldos", 90);
        studentGrades.Add("Nurzhan", 85);
        studentGrades.Add("Nurlan", 80);
        studentGrades.Add("Bekzat", 75);

        Console.Write("Бағасын білу үшін студенттің атын енгізіңіз: ");
        string name = Console.ReadLine() ?? " ";

        if (studentGrades.TryGetValue(name, out int grade))
        {
            Console.WriteLine($"{name} студентінің бағасы: {grade}");
        }
        else
        {
            Console.WriteLine("Мұндай студент табылмады.");
        }
    }
}