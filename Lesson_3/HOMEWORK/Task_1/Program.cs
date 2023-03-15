//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

void palindrome(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        Console.WriteLine($"{num} -> палиндром");
    }
    else
        Console.WriteLine($"{num} -> не палиндром");

}

palindrome(number);