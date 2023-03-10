// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


void divide(int number)
{
    if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
divide(num);