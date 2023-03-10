// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void IsItDayOff(int num)
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine("Это будний день");
    }
    else if (num >= 6 && num <= 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Такого дня недели нет");
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели:");
int day = int.Parse(Console.ReadLine()!);

IsItDayOff(day);