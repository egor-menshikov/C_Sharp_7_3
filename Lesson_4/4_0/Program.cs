// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.


int sumToNum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int result = sumToNum(a);
Console.WriteLine(result);