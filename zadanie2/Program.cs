using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m) && m >= 0)
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int result = AckermannFunction(m, n);
                Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод для n. Пожалуйста, введите неотрицательное целое число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для m. Пожалуйста, введите неотрицательное целое число.");
        }
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
