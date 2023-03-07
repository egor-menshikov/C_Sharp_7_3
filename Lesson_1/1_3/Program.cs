// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// Решаю исходя из того что "в промежутке" означает не включительно.

Console.WriteLine("enter a number: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = -num1;

if (num1 < num2)
{
    num1 += 1;
    while (num1 < num2)
    {
        Console.Write(num1);
        Console.Write(" ");
        num1++;
    }
}
else
{
    num2 += 1;
    while (num2 < num1)
    {
        Console.Write(num2);
        Console.Write(" ");
        num2++;
    }
}