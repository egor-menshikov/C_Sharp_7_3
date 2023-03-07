// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Please input the first number: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please input the second number: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2 * num2)
{
    Console.WriteLine("The first number equals second squared.");
}
else
{
    Console.WriteLine("The first number does not equal second squared.");
}