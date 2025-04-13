using System;

class Program
{
    static void Main()
    {
        Console.Title = "Артамонов Денис, КІБ-1-24-4.0д";

        double A, X = 0, Y = 0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Автор: Артамонов Денис, Варіант 1\n");
        Console.ResetColor();

        Console.Write("Введiть дiйсне число A: ");
        bool isValid = double.TryParse(Console.ReadLine(), out A);
        if (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некоректне введення! Треба ввести дiйсне число.");
            Console.ResetColor();
            return;
        }

        X = (A + 3.2) / 2.5;

        if (X > 0)
            Y = 2 * Math.Sin(X);
        else if (X >= -5 && X <= 0)
            Y = 6 - X * X;
        else 
            Y = 2 * X * X;

        Console.WriteLine("\nПерш нiж показати результат, дайте вiдповiдi:");
        Console.Write("1. Який оператор вибору використовується в цiй програмi? ");
        string answer1 = Console.ReadLine()?.ToLower();

        Console.Write("2. Який ще оператор вибору ви знаєте? ");
        string answer2 = Console.ReadLine()?.ToLower();

        if (answer1.Contains("if") && answer2.Contains("switch"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nРезультати:");
            Console.WriteLine($"X = {X:F2}");
            Console.WriteLine($"Y = {Y:F2}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nТреба вивчити оператори вибору.");
        }

        Console.ResetColor();
    }
}
