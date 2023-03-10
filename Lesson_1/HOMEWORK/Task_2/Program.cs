// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

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