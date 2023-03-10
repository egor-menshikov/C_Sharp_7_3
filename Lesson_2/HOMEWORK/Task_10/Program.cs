// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int ThreeDigitNum = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано число {ThreeDigitNum}");

int SecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}

Console.WriteLine($"{SecondDigit(ThreeDigitNum)} - вторая цифра");