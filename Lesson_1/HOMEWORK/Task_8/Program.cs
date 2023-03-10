// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int num = new Random().Next(2, 1001);
Console.WriteLine($"Сгенерировано число {num}");

int count = 2;
while (count <= num)
{
    Console.Write($" {count}");
    count += 2;
}