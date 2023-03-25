// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void TriCheck(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Такого треугольника не может существовать");
    }
}
Console.Write("Enter side a: ");
int one = int.Parse(Console.ReadLine()!);
Console.Write("Enter side b: ");
int two = int.Parse(Console.ReadLine()!);
Console.Write("Enter side c: ");
int three = int.Parse(Console.ReadLine()!);

TriCheck(one, two, three);