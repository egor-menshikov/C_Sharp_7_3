// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine()!);

if (num1 == num2)
{
    Console.Write(num1);
    Console.Write(" равно ");
    Console.Write(num2);
}
else if (num1 > num2)
{
    Console.Write(num1);
    Console.Write(" больше ");
    Console.Write(num2);
}
else
{
    Console.Write(num1);
    Console.Write(" меньше ");
    Console.Write(num2);
}