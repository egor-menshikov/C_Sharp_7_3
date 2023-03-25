// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fibo(int n)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i}  {a}");
        (a, b) = (b, a + b);
    }
}

Console.WriteLine("Введите количество циклов");
int x = int.Parse(Console.ReadLine()!);
Fibo(x);