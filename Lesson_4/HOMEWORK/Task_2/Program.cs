// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int numSum(int num)
{
    num = Math.Abs(num);
    int result = 0;
    
    while (num / 10 > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result + num;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int answer = numSum(number);
Console.WriteLine($"Сумма цифр числа {number} равняется {answer}");