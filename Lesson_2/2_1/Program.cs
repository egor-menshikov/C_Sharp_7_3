// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int BigNum(int num)
{
    if (num / 10 > num % 10)
    {
        int result = num / 10;
    return result;
    }
    else
    {
        int result = num % 10;
    return result;
    }
}

int twodg_num = new Random().Next(10, 100);
Console.WriteLine(twodg_num);
Console.WriteLine(BigNum(twodg_num));