// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int RecSum(int m, int n)
{
    if (n < m || n <= 0) return 0;
    else return RecSum(m, n - 1) + n;
}

Console.WriteLine();
Console.Write("Enter M: ");
int valM = int.Parse(Console.ReadLine()!);
Console.Write("Enter N: ");
int valN = int.Parse(Console.ReadLine()!);

int answer = RecSum(valM, valN);
Console.WriteLine();
Console.WriteLine(answer);