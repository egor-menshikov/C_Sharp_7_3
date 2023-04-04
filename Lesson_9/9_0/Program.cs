// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void NatNum(int n)
{
    if (n < 1 ) return;
    NatNum(n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Enter N: ");
int num = int.Parse(Console.ReadLine()!);
NatNum(num);