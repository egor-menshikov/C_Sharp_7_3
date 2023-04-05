// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// // натуральные числа в промежутке от M до N с помощью рекурсии.
// // M = 1; N = 5 -> "2, 4"
// // M = 4; N = 8 -> "4, 6, 8"

void EvenCount(int m, int n)
{
    if (n < m || n < 2) return;
    else if (n % 2 == 0)
    {
        EvenCount(m, n - 2);
        Console.Write($"{n} ");
    }
    else 
    {
        EvenCount(m, n - 3);
        Console.Write($"{n - 1} ");
    }
}

Console.Write("Enter M: ");
int valM = int.Parse(Console.ReadLine()!);
Console.Write("Enter N: ");
int valN = int.Parse(Console.ReadLine()!);

EvenCount(valM, valN);