// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

void square(int num)
{ 
    int i;
    for (i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 2)} ");
    }
}

square(number);
