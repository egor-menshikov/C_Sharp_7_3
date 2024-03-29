﻿// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int power(int num, int pow)
{
    int result = num;
    for (int i = 1; i < pow; i++)
    {
        result *= num;
    }
    return result;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("В какую степень будем возводить? ");
int b = int.Parse(Console.ReadLine()!);

int answer = power(a, b);
Console.WriteLine($"{a} в степени {b} равняется {answer}");