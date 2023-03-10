// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// Решаю для положительного чтобы не усложнять.

void ThirdDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"У числа {num} нет третьей цифры");
    }
    else
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine($"Третья цифра этого числа это {num}");
    }
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

ThirdDigit(number);