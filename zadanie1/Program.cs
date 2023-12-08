using System;

class Program
{
    static void Main()
    {
        int m, n;

        do
        {
            m = GetIntegerInput("Введите значение M: ");
            n = GetIntegerInput("Введите значение N: ");

            if (m > n)
            {
                Console.WriteLine("Значение M должно быть меньше или равно N. Пожалуйста, введите значения заново.");
            }
        } while (m > n);

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
        PrintNaturalNumbers(m, n);
    }

    static int GetIntegerInput(string prompt)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            return GetIntegerInput(prompt);
        }
    }

    static void PrintNaturalNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.WriteLine(current);
            PrintNaturalNumbers(current + 1, end);
        }
    }
}

