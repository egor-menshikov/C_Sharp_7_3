// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти (1-4):");
int quart = int.Parse(Console.ReadLine()!);

void Quarter(int num)
{
    if (num < 1 || num > 4)
        Console.WriteLine("Неверный ввод");
    else if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (num == 4)
        Console.WriteLine("x > 0, y < 0");
}

Quarter(quart);