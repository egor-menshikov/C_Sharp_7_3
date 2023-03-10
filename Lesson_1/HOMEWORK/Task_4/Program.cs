// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter third number: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 < num2)
{
    num1 = num2;      
}
if (num1 < num3)
{
    num1 = num3;
}
Console.WriteLine($"{num1} - максимальное из трех чисел");