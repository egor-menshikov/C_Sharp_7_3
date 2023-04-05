// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void NatNum(int m, int n)
{
    if (n < m ) return;
    NatNum(m, n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Enter M: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N: ");
int num2 = int.Parse(Console.ReadLine()!);
NatNum(num1, num2);